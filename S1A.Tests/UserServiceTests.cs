using System.Threading.Tasks;
using S1A.Services;
using Xunit;

namespace S1A.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public async Task GetUserRoleAsync_ReturnsExpectedRole()
        {
            // Arrange
            var service = new UserService();

            // Act
            var role = await service.GetUserRoleAsync(1);

            // Assert
            Assert.Equal("Admin", role);
        }
    }
}