using System.Threading.Tasks;

namespace S1A.Services
{
    public class UserService : IUserService
    {
        public Task<string> GetUserRoleAsync(int id)
        {
            return Task.FromResult(id == 1 ? "Admin" : "User");
        }       
    }
}