param(
    [Parameter(Mandatory = $true)]
    [string]$Token
)

# Project configuration
$projectKey = "securitydemo"
$projectName = "SecurityDemo"
$projectVersion = "1.0"
$sourceDir = "S1A"
$testProject = "S1A.Tests/S1A.Tests.csproj"
$mainProject = "S1A/SecurityDemo.csproj"
$coverageOutput = "coverage.opencover.xml"
$testDllPath = "S1A.Tests/bin/Debug/net9.0/S1A.Tests.dll"

# Step 1: Restore projects
Write-Host "`nRestoring projects..."
dotnet restore $mainProject
dotnet restore $testProject

if ($LASTEXITCODE -ne 0) {
    Write-Error "Restore failed. Aborting."
    exit 1
}

# Step 2: Ensure coverlet.console is installed and available
$toolPath = "$env:USERPROFILE\.dotnet\tools"
if (-not (Test-Path "$toolPath\coverlet.exe")) {
    Write-Host "`nInstalling coverlet.console..."
    dotnet tool install --global coverlet.console --ignore-failed-sources
}
if (-not ($env:PATH -like "*$toolPath*")) {
    $env:PATH += ";$toolPath"
}

# Step 3: Build test project (so test DLL exists)
Write-Host "`nBuilding test project..."
dotnet build $testProject --configuration Debug

if ($LASTEXITCODE -ne 0 -or !(Test-Path $testDllPath)) {
    Write-Error "Test build failed or DLL not found at $testDllPath. Aborting."
    exit 1
}

# Step 4: Run tests with coverage using coverlet.console
Write-Host "`nRunning tests and collecting coverage..."
coverlet $testDllPath `
  --target "dotnet" `
  --targetargs "test $testProject --no-build" `
  --format opencover `
  --output "$coverageOutput"

if ($LASTEXITCODE -ne 0 -or !(Test-Path $coverageOutput)) {
    Write-Error "Coverage collection failed or report not found. Aborting."
    exit 1
}

# Step 5: Start SonarQube scan
Write-Host "`nStarting SonarQube scanner..."
dotnet sonarscanner begin `
  /k:"$projectKey" `
  /n:"$projectName" `
  /v:"$projectVersion" `
  /d:sonar.login="$Token" `
  /d:sonar.host.url="http://localhost:9000" `
  /d:sonar.cs.opencover.reportsPaths="$coverageOutput" `
  /d:sonar.sources="$sourceDir" `
  /d:sonar.verbose=true

if ($LASTEXITCODE -ne 0) {
    Write-Error "SonarScanner 'begin' failed. Aborting."
    exit 1
}

# Step 6: Build main project
Write-Host "`nBuilding main project..."
dotnet build $mainProject --no-incremental

if ($LASTEXITCODE -ne 0) {
    Write-Error "Main project build failed. Aborting."
    exit 1
}

# Step 7: End SonarQube scan
Write-Host "`nFinalizing SonarQube scan..."
dotnet sonarscanner end /d:sonar.login="$Token"

if ($LASTEXITCODE -ne 0) {
    Write-Error "SonarScanner 'end' failed. Aborting."
    exit 1
}

Write-Host "`nScan completed successfully."