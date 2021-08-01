using System.Threading.Tasks;

namespace ConsultaEndereco.Core.Http
{
    public interface IHttpClientManagement
    {
        Task<T> GetAsync<T>(string url);

        Task PostAsJsonAsync<T>(string url, T content);

        Task<T> PostAsJsonAsync<T>(string url, string content, bool useToken = false, bool useClientId = false);
    }
}
