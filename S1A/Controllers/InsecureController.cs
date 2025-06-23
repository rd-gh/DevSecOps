using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace SecurityDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsecureController : ControllerBase
    {
        // ❌ Hardcoded secret (will be caught by Semgrep and Gitleaks)
        private string apiKey = "sk_test_1234567890abcdef";

        [HttpGet("external-call")]
        public async Task<string> GetFromInsecureEndpoint()
        {
            // ❌ Insecure HTTP usage (Semgrep warning)
            using var client = new HttpClient();
            var result = await client.GetStringAsync("http://example.com/data");
            return result;
        }

        [HttpGet("unformatted")]public string BadlyFormatted()=> "No space here";
    }
}
