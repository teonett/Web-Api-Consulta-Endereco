﻿using ConsultaEndereco.Core.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaEndereco.Service.Http
{
    public class HttpClientManagement : IHttpClientManagement
    {
        public readonly HttpClient _httpClient;

        public HttpClientManagement(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> GetAsync<T>(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }

        public async Task PostAsJsonAsync<T>(string url, T content)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, stringContent);

            response.EnsureSuccessStatusCode();
        }

        public async Task<T> PostAsJsonAsync<T>(string url, string content, bool useToken = false, bool useClientId = false)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(content, Encoding.UTF8, "application/json")
            };

            var response = await _httpClient.SendAsync(request);

            return JsonConvert.DeserializeObject<T>(await response.EnsureSuccessStatusCode().Content.ReadAsStringAsync());
        }
    }
}
