# 📝 SonarQube Analysis Summary

## 📊 Measures

- **coverage**: 27.8
- **lines_to_cover**: 52
- **branch_coverage**: 100.0
- **uncovered_lines**: 39
- **line_coverage**: 25.0

## 🐞 Issues

- [CRITICAL] `securitydemo:S1A/Services/UserService.cs`: Rename parameter 'id' to 'userId' to match the interface declaration.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Remove the unused private field 'apiKey'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Make 'apiKey' 'readonly'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: The field 'InsecureController.apiKey' is assigned but its value is never used
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: The field 'InsecureController.sonarToken' is assigned but its value is never used
- [BLOCKER] `securitydemo:S1A/Controllers/InsecureController.cs`: Make sure this SonarQube token gets revoked, changed, and removed from the code.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Make 'sonarToken' 'readonly'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Remove the unused private field 'sonarToken'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Remove the unused private field 'githubToken'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: The field 'InsecureController.githubToken' is assigned but its value is never used
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Make 'githubToken' 'readonly'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Make 'awsKey' 'readonly'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Remove the unused private field 'awsKey'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: The field 'InsecureController.awsKey' is assigned but its value is never used
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Remove the unused private field 'awsSecret'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Make 'awsSecret' 'readonly'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: The field 'InsecureController.awsSecret' is assigned but its value is never used
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Remove the unused private field 'slackWebhook'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Make 'slackWebhook' 'readonly'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: The field 'InsecureController.slackWebhook' is assigned but its value is never used
- [MINOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Remove the unused local variable 'obj'.
- [MAJOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Reuse HttpClient instances rather than create new ones with each controller action invocation.
- [MINOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Refactor your code not to use hardcoded absolute paths or URIs.
- [MINOR] `securitydemo:S1A/Controllers/InsecureController.cs`: Remove this method and declare a constant for this value.
- [MAJOR] `securitydemo:S1A/Program.cs`: Await RunAsync instead.
- [MINOR] `securitydemo:S1A/Controllers/VulnerableController.cs`: Remove the unused local variable 'reader'.
- [MINOR] `securitydemo:S1A/Controllers/VulnerableController.cs`: Remove the unused local variable 'reader'.
- [BLOCKER] `securitydemo:S1A/appsettings.json`: Make sure this database password gets changed and removed from the code.

## 🔥 Security Hotspots

- [TO_REVIEW] `securitydemo:S1A/appsettings.json`: "password" detected here, make sure this is not a hard-coded credential.
- [TO_REVIEW] `securitydemo:S1A/Controllers/InsecureController.cs`: "apiKey" detected here, make sure this is not a hard-coded secret.
- [TO_REVIEW] `securitydemo:S1A/Controllers/InsecureController.cs`: "sonarToken" detected here, make sure this is not a hard-coded secret.
- [TO_REVIEW] `securitydemo:S1A/Controllers/InsecureController.cs`: "githubToken" detected here, make sure this is not a hard-coded secret.
- [TO_REVIEW] `securitydemo:S1A/Controllers/InsecureController.cs`: "awsSecret" detected here, make sure this is not a hard-coded secret.
- [TO_REVIEW] `securitydemo:S1A/appsettings.json`: "ApiKey" detected here, make sure this is not a hard-coded secret.
- [TO_REVIEW] `securitydemo:S1A/Controllers/VulnerableController.cs`: Make sure using a dynamically formatted SQL query is safe here.
- [TO_REVIEW] `securitydemo:S1A/Controllers/VulnerableController.cs`: Make sure using a dynamically formatted SQL query is safe here.

