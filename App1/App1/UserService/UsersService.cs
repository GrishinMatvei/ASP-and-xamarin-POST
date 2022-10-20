using App1.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
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


        //ip sharaga pc4 http://192.168.10.104:3000/
        //ip hata http://192.168.27.111:3000/

        public async void Add(User user)
        {
            var httpClient = new HttpClient();
            var content = JsonConvert.SerializeObject(user);
            HttpContent httpContent = new StringContent(content, Encoding.UTF8);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var uri = new Uri("http://192.168.27.111:3000/users/createuser");
            HttpResponseMessage response = await httpClient.PostAsync(uri, httpContent);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();

                string ss = data;
            }
        }
    }
}

