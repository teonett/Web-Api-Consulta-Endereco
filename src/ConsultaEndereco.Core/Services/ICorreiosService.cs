using ConsultaEndereco.Core.Entities;
using System.Threading.Tasks;

namespace ConsultaEndereco.Core.Services
{
    public interface ICorreiosService
    {
        Task<Correios> Get(string zipCodeAddress);
    }
}
