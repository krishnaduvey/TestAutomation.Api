using NUnit.Framework;
using TestAutomation.RestApi.Base;
using TestAutomation.RestApi.Core;
using TestAutomation.RestApi.Models.Requests;
using TestAutomation.RestApi.Models.Response;
using TestAutomation.RestApi.Services;

namespace TestAutomation.RestApi.Tests
{
    [TestFixture]
    public class UserTests: BaseTests
    {
        private UserServices _userService;

        [SetUp] // runs before each test
        public void Setup()
        {
            _userService = new UserServices(ApiClient);
        }

        [Test]
        public async Task CreateUser_ShouldReturnSuccess() {
            var userService = new UserServices(ApiClient);

            var request = new CreateUserRequest
            {
                Name = "name",
                Job = "SDET"
            };

            var response = await userService.CreateUser(request);
            Assert.True(response.IsSuccessStatusCode, "Expected 200 as status code");

            var userResponse = await ResponseHandler.DeserializeResponse<UserResponse>(response);


            Assert.NotNull(userResponse);
            Assert.AreEqual(request.Name, userResponse.Name, "Name should match");
            Assert.AreEqual(request.Job, userResponse.Job, "Job should match");
        }
    }
}
