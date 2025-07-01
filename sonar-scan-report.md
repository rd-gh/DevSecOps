# 📊 SonarQube Summary Report for `securitydemo`

## ✅ Project Measures

- **Coverage**: 27.8
- **Bugs**: 0
- **Code Smells**: 25
- **Duplicated Lines Density**: 0.0
- **Vulnerabilities**: 2

---
## 🔥 Security Hotspots

- **Message**: "password" detected here, make sure this is not a hard-coded credential.
  - **File**: `securitydemo:S1A/appsettings.json`
  - **Line**: 3
  - **Status**: TO_REVIEW

- **Message**: "apiKey" detected here, make sure this is not a hard-coded secret.
  - **File**: `securitydemo:S1A/Controllers/InsecureController.cs`
  - **Line**: 12
  - **Status**: TO_REVIEW

- **Message**: "sonarToken" detected here, make sure this is not a hard-coded secret.
  - **File**: `securitydemo:S1A/Controllers/InsecureController.cs`
  - **Line**: 13
  - **Status**: TO_REVIEW

- **Message**: "githubToken" detected here, make sure this is not a hard-coded secret.
  - **File**: `securitydemo:S1A/Controllers/InsecureController.cs`
  - **Line**: 14
  - **Status**: TO_REVIEW

- **Message**: "awsSecret" detected here, make sure this is not a hard-coded secret.
  - **File**: `securitydemo:S1A/Controllers/InsecureController.cs`
  - **Line**: 16
  - **Status**: TO_REVIEW

- **Message**: "ApiKey" detected here, make sure this is not a hard-coded secret.
  - **File**: `securitydemo:S1A/appsettings.json`
  - **Line**: 6
  - **Status**: TO_REVIEW

- **Message**: Make sure using a dynamically formatted SQL query is safe here.
  - **File**: `securitydemo:S1A/Controllers/VulnerableController.cs`
  - **Line**: 19
  - **Status**: TO_REVIEW

- **Message**: Make sure using a dynamically formatted SQL query is safe here.
  - **File**: `securitydemo:S1A/Controllers/VulnerableController.cs`
  - **Line**: 32
  - **Status**: TO_REVIEW


---
## 🐞 Issues (Bugs, Vulnerabilities, Code Smells)

### CODE_SMELL - CRITICAL
- **Message**: Rename parameter 'id' to 'userId' to match the interface declaration.
- **File**: `S1A/Services/UserService.cs`
- **Rule**: `csharpsquid:S927`
- **Status**: CLOSED

---

### CODE_SMELL - MAJOR
- **Message**: Remove the unused private field 'apiKey'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 12
- **Rule**: `csharpsquid:S1144`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Make 'apiKey' 'readonly'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 12
- **Rule**: `csharpsquid:S2933`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: The field 'InsecureController.apiKey' is assigned but its value is never used
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 12
- **Rule**: `external_roslyn:CS0414`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: The field 'InsecureController.sonarToken' is assigned but its value is never used
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 13
- **Rule**: `external_roslyn:CS0414`
- **Status**: OPEN

---

### VULNERABILITY - BLOCKER
- **Message**: Make sure this SonarQube token gets revoked, changed, and removed from the code.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 13
- **Rule**: `secrets:S6702`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Make 'sonarToken' 'readonly'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 13
- **Rule**: `csharpsquid:S2933`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Remove the unused private field 'sonarToken'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 13
- **Rule**: `csharpsquid:S1144`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Remove the unused private field 'githubToken'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 14
- **Rule**: `csharpsquid:S1144`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: The field 'InsecureController.githubToken' is assigned but its value is never used
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 14
- **Rule**: `external_roslyn:CS0414`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Make 'githubToken' 'readonly'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 14
- **Rule**: `csharpsquid:S2933`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Make 'awsKey' 'readonly'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 15
- **Rule**: `csharpsquid:S2933`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Remove the unused private field 'awsKey'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 15
- **Rule**: `csharpsquid:S1144`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: The field 'InsecureController.awsKey' is assigned but its value is never used
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 15
- **Rule**: `external_roslyn:CS0414`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Remove the unused private field 'awsSecret'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 16
- **Rule**: `csharpsquid:S1144`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Make 'awsSecret' 'readonly'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 16
- **Rule**: `csharpsquid:S2933`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: The field 'InsecureController.awsSecret' is assigned but its value is never used
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 16
- **Rule**: `external_roslyn:CS0414`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Remove the unused private field 'slackWebhook'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 17
- **Rule**: `csharpsquid:S1144`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Make 'slackWebhook' 'readonly'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 17
- **Rule**: `csharpsquid:S2933`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: The field 'InsecureController.slackWebhook' is assigned but its value is never used
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 17
- **Rule**: `external_roslyn:CS0414`
- **Status**: OPEN

---

### CODE_SMELL - MINOR
- **Message**: Remove the unused local variable 'obj'.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 22
- **Rule**: `csharpsquid:S1481`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Reuse HttpClient instances rather than create new ones with each controller action invocation.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 29
- **Rule**: `csharpsquid:S6962`
- **Status**: OPEN

---

### CODE_SMELL - MINOR
- **Message**: Refactor your code not to use hardcoded absolute paths or URIs.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 30
- **Rule**: `csharpsquid:S1075`
- **Status**: OPEN

---

### CODE_SMELL - MINOR
- **Message**: Remove this method and declare a constant for this value.
- **File**: `S1A/Controllers/InsecureController.cs`
- **Line**: 34
- **Rule**: `csharpsquid:S3400`
- **Status**: OPEN

---

### CODE_SMELL - MAJOR
- **Message**: Await RunAsync instead.
- **File**: `S1A/Program.cs`
- **Line**: 19
- **Rule**: `csharpsquid:S6966`
- **Status**: OPEN

---

### CODE_SMELL - MINOR
- **Message**: Remove the unused local variable 'reader'.
- **File**: `S1A/Controllers/VulnerableController.cs`
- **Line**: 33
- **Rule**: `csharpsquid:S1481`
- **Status**: OPEN

---

### CODE_SMELL - MINOR
- **Message**: Remove the unused local variable 'reader'.
- **File**: `S1A/Controllers/VulnerableController.cs`
- **Line**: 21
- **Rule**: `csharpsquid:S1481`
- **Status**: OPEN

---

### VULNERABILITY - BLOCKER
- **Message**: Make sure this database password gets changed and removed from the code.
- **File**: `S1A/appsettings.json`
- **Line**: 3
- **Rule**: `secrets:S6703`
- **Status**: OPEN

---

