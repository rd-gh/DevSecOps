using System.Threading.Tasks;

namespace S1A.Services
{
    public interface IUserService
    {
        Task<string> GetUserRoleAsync(int id);
    }
}