using ConsultaEndereco.Core.Entities;
using System.Threading.Tasks;

namespace ConsultaEndereco.Core.Services
{
    public interface IPostmonService
    {
        Task<Postmon> Get(string zipCode);
    }
}
