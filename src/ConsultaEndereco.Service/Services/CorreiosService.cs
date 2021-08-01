using ConsultaEndereco.Core.Entities;
using ConsultaEndereco.Core.Http;
using ConsultaEndereco.Core.Services;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsultaEndereco.Service.Services
{
    public class CorreiosService : ICorreiosService
    {
        private readonly IConfiguration config;
        private readonly IHttpClientManagement _httpClientManagement;
        private readonly string urlBase;

        public CorreiosService(IConfiguration config, IHttpClientManagement httpClientManagement)
        {
            this.config = config;
            this._httpClientManagement = httpClientManagement;
            this.urlBase = config.GetSection("BaseUrlAddress").GetSection("UrlCorreios").Value;
        }

        public async Task<Correios> Get(string zipCodeAddress)
        {
            var client = new HttpClient();

            using (var response = await client.PostAsync(urlBase, CreateZipCodeRequest(zipCodeAddress)))
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var correiosAddressResponse = JsonConvert.DeserializeObject<Correios>(jsonResponse);

                if (correiosAddressResponse != null && !correiosAddressResponse.Erro)
                {
                    return correiosAddressResponse;
                }
            }

            return null;
        }

        private FormUrlEncodedContent CreateZipCodeRequest(string zipCode)
        {
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("endereco", zipCode),
                new KeyValuePair<string, string>("tipoCEP", "ALL")

            });

            return content;
        }
    }
}
