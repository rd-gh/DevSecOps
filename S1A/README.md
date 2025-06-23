# 🛡️ SecurityDemo: .NET Core App with GitHub Security Pipeline

Welcome to the `SecurityDemo` project — a deliberately vulnerable ASP.NET Core Web API built to showcase a fully automated security pipeline using GitHub Actions 🚀.

## 🔍 Security Tools Implemented

| Tool              | Purpose                              |
|-------------------|---------------------------------------|
| 🔒 Semgrep        | Static code analysis (SAST) for C#    |
| 🛡️ CodeQL         | GitHub-native SAST for C#             |
| 🧪 OWASP DepCheck | Dependency vulnerability scanning     |
| 🔐 Gitleaks       | Hardcoded secret detection            |
| 🧹 dotnet-format  | Code style & formatting enforcement   |

---

## ⚙️ Configuration Details

### ✅ Semgrep
- Uses [`p/csharp`](https://semgrep.dev/p/csharp) community ruleset.
- Triggers on PRs and `main` pushes.
- Output is shown in GitHub Security → Code scanning alerts.

### ✅ OWASP Dependency-Check
- Scans `*.csproj` for known vulnerable NuGet packages.
- Uses HTML report (downloadable via GitHub Actions artifacts).

### ✅ Gitleaks
- Scans for secrets like `sk_test_*`, `Password=...`, AWS keys, etc.
- Triggers on every commit and PR.

### ✅ CodeQL
- Runs GitHub’s own static code analysis.
- Targets C# logic bugs, insecure patterns, injection issues.
- Outputs results to GitHub → Security → Code scanning alerts.

### ✅ dotnet-format
- Enforces clean code structure.
- Fails CI if spacing, brace style, or line breaks are incorrect.

---

## 🤔 Why These Checks?

- **Semgrep** helps catch insecure coding patterns and logic flaws.
- **OWASP DC** protects against CVEs in your libraries.
- **Gitleaks** avoids publishing secrets into version control.
- **dotnet-format** keeps code consistent and team-friendly.

---

## 📈 How to Interpret Results

- Go to the **Actions** tab → Click latest run.
- View logs for each job:
  - **Semgrep:** Flags shown in GitHub → Security → Code Scanning Alerts
  - **Gitleaks:** Logs will show secret matches.
  - **OWASP DC:** Artifact includes full HTML vulnerability report.
  - **dotnet-format:** Lists the files with bad formatting.

---

## 🧪 Custom Rules or Configurations

- ✅ Intentionally included:
  - Hardcoded API key in controller
  - Insecure `http://` call
  - Old vulnerable version of `Newtonsoft.Json`
  - Misformatted code

All of these are picked up by the pipeline — check it in action! 🎯

---

Enjoy securing your code! 🔐🧑‍💻
