using System.Text.Json;

namespace TestAutomation.RestApi.Core
{
    public static class ResponseHandler
    {
        public static async Task<T> DeserializeResponse<T>(HttpResponseMessage responseMessage)
        {
            var json = await responseMessage.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
