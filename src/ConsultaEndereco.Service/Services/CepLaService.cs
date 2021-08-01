using ConsultaEndereco.Core.Entities;
using ConsultaEndereco.Core.Http;
using ConsultaEndereco.Core.Services;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultaEndereco.Service.Services
{
    public class CepLaService : ICepLaService
    {
        private readonly IConfiguration config;
        private readonly IHttpClientManagement _httpClientManagement;
        private readonly string urlBase;

        public CepLaService(IConfiguration config, IHttpClientManagement httpClientManagement)
        {
            this.config = config;
            this._httpClientManagement = httpClientManagement;
            this.urlBase = config.GetSection("BaseUrlAddress").GetSection("UrlCepLa").Value;
        }

        public async Task<List<CepLa>> Get(string zipCodeAddress)
        {
            var fullUrl = $"{urlBase}{zipCodeAddress.Replace("-", "")}";
            var enderecos = new List<CepLa>();

            try
            {
                var retObject = await _httpClientManagement.GetAsync<CepLa>(fullUrl);
                enderecos.Add(retObject);
            }
            catch
            {
                var retList = await _httpClientManagement.GetAsync<List<CepLa>>(fullUrl);
                enderecos.AddRange(retList);
            }

            return enderecos;
        }
    }
}
