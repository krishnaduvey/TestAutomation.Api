using TestAutomation.RestApi.Core;
using TestAutomation.RestApi.Models.Requests;

namespace TestAutomation.RestApi.Services
{
    public class UserServices
    {
        private readonly ApiClient _client;

        public UserServices(ApiClient client)
        {
            _client = client;
        }

        public async Task<HttpResponseMessage> CreateUser(CreateUserRequest createUserRequest)
        {
            return await _client.PostAsync("users", createUserRequest);
        }

    }
}
