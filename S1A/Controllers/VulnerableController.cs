using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace S1A.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VulnerableController : ControllerBase
    {
        [HttpGet("{username}")]
        public IActionResult GetUser(string username)
        {
            // 🚨 SQL Injection vulnerability
            var query = "SELECT * FROM Users WHERE Username = '" + username + "'";

            using (var connection = new SqlConnection("YourConnectionString"))
            {
                var command = new SqlCommand(query, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                return Ok("User fetched");
            }
        }
    }
}