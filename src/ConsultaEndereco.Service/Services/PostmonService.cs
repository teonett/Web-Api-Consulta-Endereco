using ConsultaEndereco.Core.Entities;
using ConsultaEndereco.Core.Http;
using ConsultaEndereco.Core.Services;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace ConsultaEndereco.Service.Services
{
    public class PostmonService : IPostmonService
    {
        private readonly IConfiguration config;
        private readonly IHttpClientManagement _httpClientManagement;
        private readonly string urlBase;

        public PostmonService(IConfiguration config, IHttpClientManagement httpClientManagement)
        {
            this.config = config;
            this._httpClientManagement = httpClientManagement;
            this.urlBase = config.GetSection("BaseUrlAddress").GetSection("UrlPostmon").Value;
        }

        public async Task<Postmon> Get(string zipCode)
        {
            string fullUrl = $"{urlBase}/v1/cep/{zipCode.Replace("-", "")}";
            return await _httpClientManagement.GetAsync<Postmon>(fullUrl);
        }
    }
}
