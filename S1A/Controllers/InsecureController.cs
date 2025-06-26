using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace SecurityDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsecureController : ControllerBase
    {
        private string apiKey = "sk_test_1234567890abcdef";

        [HttpPost("deserialize")]
        public IActionResult InsecureDeserialization([FromBody] string payload)
        {
            var obj = JsonConvert.DeserializeObject(payload);
            return Ok("Deserialized");
        }

        [HttpGet("external-call")]
        public async Task<string> GetFromInsecureEndpoint()
        {
            using var client = new HttpClient();
            var result = await client.GetStringAsync("http://example.com/data");
            return result;
        }

        [HttpGet("unformatted")]public string BadlyFormatted()=> "No space here";
    }
}
