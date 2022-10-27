using App1.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace App1.UserService
{
    public class UsersService
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        public string Add(User user)
        { 
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            Uri uri = new Uri("http://192.168.10.104:3000/users/createuser");
            Task<string> data = Post(uri, httpContent);
            return data.Result; 
        }

        private async Task<string> Post(Uri uri, HttpContent httpContent)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.PostAsync(uri, httpContent).ConfigureAwait(false);

            Task<string> data = response.Content.ReadAsStringAsync(); 
            return data.Result;
        }
    }
}

