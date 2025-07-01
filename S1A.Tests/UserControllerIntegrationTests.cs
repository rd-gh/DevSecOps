using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using S1A.Controllers;
using S1A.Services;
using S1A.Models;
using Xunit;

namespace S1A.Tests
{
    public class UserControllerIntegrationTests
    {
        [Fact]
        public async Task GetUserRole_ReturnsCorrectRole()
        {
            // Arrange
            var userService = new UserService(); // real one
            var controller = new UserController(userService);

            // Act
            var result = await controller.GetUserRole(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var response = Assert.IsType<RoleResponse>(okResult.Value);

            Assert.Equal(1, response.UserId);
            Assert.Equal("Admin", response.Role);
        }
    }
}