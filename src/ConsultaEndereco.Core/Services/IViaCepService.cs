using ConsultaEndereco.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultaEndereco.Core.Services
{
    public interface IViaCepService
    {
        Task<ViaCep> Get(string zipCode);
        Task<List<ViaCep>> Get(string stateInitials, string city, string address);
    }
}
