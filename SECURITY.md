# 🔒 Security Policy

## Supported Versions

We are committed to keeping this project secure. The following versions are currently supported with security updates:

| Version | Supported |
|---------|-----------|
| Latest  | ✅ Yes     |
| Older   | ❌ No      |

---

## Reporting a Vulnerability

If you discover a security vulnerability in this project, please **do not create a public issue**.

Instead, report it confidentially by contacting:

📧 **security@example.com**  
🔐 Or use GitHub's private vulnerability reporting feature (if enabled).

We will investigate and respond as quickly as possible. Thank you for helping to keep our project secure.

---

## Security Checks in Place

This repository uses **GitHub Advanced Security (GHAS)** to automate security best practices:

- ✅ **Code Scanning (Semgrep, CodeQL)**  
- ✅ **Secret Scanning**
- ✅ **Dependabot Alerts**
- ✅ **Dependency Scanning with Snyk**

These tools are configured to run on:
- Pushes to `main`
- Pull requests targeting `main`
- Scheduled weekly scans (optional)

Results are reviewed regularly and high/critical issues are prioritized for immediate remediation.

---

## How to Interpret Alerts

Security alerts and scan reports are visible under the **Security** tab of this repository:
- **Code Scanning Alerts**: Review flagged vulnerabilities and trace to affected lines.
- **Dependabot Alerts**: Identify dependency issues and apply suggested upgrades.
- **Secret Scanning Alerts**: Revoke exposed credentials immediately and rotate keys.

For contributors: Any pull request that introduces new issues will be automatically blocked by branch protection rules.

---

## Custom Rules & Configuration

- Custom Semgrep rules tailored for C# vulnerabilities
- Fail pipelines on critical severity issues (`CVSS >= 7.0`)
- Auto-upload of SARIF reports for visualization in GitHub Security tab

---

## Questions?

If you have questions about this policy or how to report a vulnerability, please open a discussion or contact us directly via email.