using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultaEndereco.Core.Entities;

namespace ConsultaEndereco.Core.Services
{
    public interface ICepLaService
    {
        Task<List<CepLa>> Get(string zipCodeAddress);
    }
}
