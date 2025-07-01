using Xunit;
using S1A.Controllers;
using S1A.Services;
using S1A.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace S1A.Tests
{
    public class UserControllerTests
    {
        [Fact]
        public async Task GetUserRole_ReturnsAdmin_ForId1()
        {
            var userService = new UserService();
            var controller = new UserController(userService);

            var result = await controller.GetUserRole(1);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var data = Assert.IsType<RoleResponse>(okResult.Value);

            Assert.Equal("Admin", data.Role);
            Assert.Equal(1, data.UserId);
        }

        [Fact]
        public async Task GetUserRole_ReturnsUser_ForNonAdminId()
        {
            var userService = new UserService();
            var controller = new UserController(userService);

            var result = await controller.GetUserRole(2);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var data = Assert.IsType<RoleResponse>(okResult.Value);

            Assert.Equal("User", data.Role);
            Assert.Equal(2, data.UserId);
        }

    }
}