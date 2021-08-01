using ConsultaEndereco.Core.Entities;
using ConsultaEndereco.Core.Http;
using ConsultaEndereco.Core.Services;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsultaEndereco.Service.Services
{
    public class ViaCepService : IViaCepService
    {
        private readonly IConfiguration config;
        private readonly IHttpClientManagement _httpClientManagement;
        private readonly string urlBase;

        public ViaCepService(IConfiguration config, IHttpClientManagement httpClientManagement)
        {
            this.config = config;
            this._httpClientManagement = httpClientManagement;
            this.urlBase = config.GetSection("BaseUrlAddress").GetSection("UrlViaCep").Value;
        }

        public async Task<ViaCep> Get(string zipCode)
        {
            string fullUrl = $"{urlBase}/ws/{zipCode.Replace("-", "")}/json/";
            return await _httpClientManagement.GetAsync<ViaCep>(fullUrl);
        }

        public async Task<List<ViaCep>> Get(string stateInitials, string city, string address)
        {
            var fullUrl = $"{urlBase}/ws/" +
                          $"{RemoveSpecialCharacter(stateInitials.Trim())}/" +
                          $"{RemoveSpecialCharacter(city.Trim())}/" +
                          $"{RemoveSpecialCharacter(address)}/json/";
            var enderecos = new List<ViaCep>();

            try
            {
                var retItem = await _httpClientManagement.GetAsync<ViaCep>(fullUrl);
                enderecos.Add(retItem);
                return enderecos;
            }
            catch
            {
                var retItens = await _httpClientManagement.GetAsync<List<ViaCep>>(fullUrl);
                enderecos.AddRange(retItens);

                return enderecos;
            }
        }

        private string RemoveSpecialCharacter(string texto)
        {
            return Regex.Replace(texto, "[^0-9a-zA-Z]+", " ");
        }
    }
}
