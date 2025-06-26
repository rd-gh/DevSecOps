
# ?? GitHub Security Report

This report summarizes all **CodeQL**, **Dependabot**, and **Secret Scanning** alerts in [rd-gh/DevSecOps](https://github.com/rd-gh/DevSecOps/security).

---
### ?? CodeQL Alerts

- **Rule**: cs/sql-injection  
  - **Severity**: error  
  - **Description**: SQL query built from user-controlled sources  
  - **Location**: [S1A/Controllers/VulnerableController.cs](https://github.com/rd-gh/DevSecOps/blob/main/S1A/Controllers/VulnerableController.cs#L19)  
  - **Lines**: 19 - 19  
  - **Fix**: Review the vulnerable pattern and apply secure coding standards.

- **Rule**: cs/sql-injection  
  - **Severity**: error  
  - **Description**: SQL query built from user-controlled sources  
  - **Location**: [S1A/Controllers/VulnerableController.cs](https://github.com/rd-gh/DevSecOps/blob/main/S1A/Controllers/VulnerableController.cs#L32)  
  - **Lines**: 32 - 32  
  - **Fix**: Review the vulnerable pattern and apply secure coding standards.

### ?? Dependabot Alerts

- **Package**: DotNetZip (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: high  
  - **Summary**: DotNetZip Directory Traversal vulnerability   
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-xhg6-9j5j-w4vf](https://github.com/advisories/GHSA-xhg6-9j5j-w4vf)

- **Package**: bootstrap (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: medium  
  - **Summary**: Bootstrap vulnerable to Cross-Site Scripting (XSS)   
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-3wqf-4x89-9g79](https://github.com/advisories/GHSA-3wqf-4x89-9g79)

- **Package**: bootstrap (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: medium  
  - **Summary**: Bootstrap Cross-Site Scripting (XSS) vulnerability   
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-9mvj-f7w8-pvh2](https://github.com/advisories/GHSA-9mvj-f7w8-pvh2)

- **Package**: bootstrap (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: medium  
  - **Summary**: Bootstrap Cross-site Scripting vulnerability   
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-4p24-vmcr-4gqj](https://github.com/advisories/GHSA-4p24-vmcr-4gqj)

- **Package**: bootstrap (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: medium  
  - **Summary**: Bootstrap Cross-site Scripting vulnerability   
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-7mvr-5x2g-wfc8](https://github.com/advisories/GHSA-7mvr-5x2g-wfc8)

- **Package**: bootstrap (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: medium  
  - **Summary**: XSS vulnerability that affects bootstrap   
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-3mgp-fx93-9xv5](https://github.com/advisories/GHSA-3mgp-fx93-9xv5)

- **Package**: bootstrap (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: medium  
  - **Summary**: bootstrap Cross-site Scripting vulnerability   
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-ph58-4vrj-w6hr](https://github.com/advisories/GHSA-ph58-4vrj-w6hr)

- **Package**: System.Data.SqlClient (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: high  
  - **Summary**: Microsoft.Data.SqlClient and System.Data.SqlClient vulnerable to SQL Data Provider Security Feature Bypass     
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-98g6-xh36-x2p7](https://github.com/advisories/GHSA-98g6-xh36-x2p7)

- **Package**: bootstrap (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: medium  
  - **Summary**: Bootstrap Vulnerable to Cross-Site Scripting   
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-9v3m-8fp8-mj99](https://github.com/advisories/GHSA-9v3m-8fp8-mj99)

- **Package**: Newtonsoft.Json (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: high  
  - **Summary**: Improper Handling of Exceptional Conditions in Newtonsoft.Json   
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-5crp-9r3c-p9vr](https://github.com/advisories/GHSA-5crp-9r3c-p9vr)

- **Package**: RestSharp (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: high  
  - **Summary**: Incorrect Regular Expression in RestSharp   
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-9pq7-rcxv-47vq](https://github.com/advisories/GHSA-9pq7-rcxv-47vq)

- **Package**: System.Text.Encodings.Web (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: critical  
  - **Summary**: .NET Core Remote Code Execution Vulnerability    
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-ghhp-997w-qr28](https://github.com/advisories/GHSA-ghhp-997w-qr28)

- **Package**: System.Net.Http (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: high  
  - **Summary**: .NET Core Information Disclosure   
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-7jgj-8wvc-jh57](https://github.com/advisories/GHSA-7jgj-8wvc-jh57)

- **Package**: DotNetZip (GitHub Actions or Transitive)  
  - **Manifest**: S1A/SecurityDemo.csproj  
  - **Severity**: medium  
  - **Summary**: DotNetZip Zip-Slip Vulnerability   
  - **Fix**: Upgrade the affected dependency to a secure version.  
  - **Advisory**: [GHSA-GHSA-7378-6268-4278](https://github.com/advisories/GHSA-7378-6268-4278)

### ?? Secret Scanning Alerts

- **Secret Type**: slack_incoming_webhook_url  
  - **Status**: open  
  - **File**: [](https://github.com/rd-gh/DevSecOps/blob/main/#L)  
  - **Line**:   
  - **Fix**: Revoke and rotate the secret. Avoid hardcoding credentials in source code.

