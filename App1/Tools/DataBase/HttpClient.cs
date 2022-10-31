using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json; 

namespace Tools.DataBase
{
    public static class HttpClient
    {
        private static Uri defaultUrl = new Uri("http://192.168.1.112:3000/");
        private static System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient(); 

        public static string Post<TValue>(string methodUrl, TValue value)
        {
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(value), Encoding.UTF8);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            Uri url = new Uri(defaultUrl.ToString() + methodUrl);
            HttpResponseMessage response = httpClient.PostAsync(url, httpContent).GetAwaiter().GetResult();

            return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        }
    }
}
