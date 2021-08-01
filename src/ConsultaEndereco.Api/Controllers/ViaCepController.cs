using ConsultaEndereco.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ConsultaEndereco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViaCepController : ControllerBase
    {
        private readonly IViaCepService service;

        public ViaCepController(IViaCepService service)
        {
            this.service = service;
        }

        [HttpGet("{zipCode}")]
        public async Task<IActionResult> Get(string zipCode)
        {
            var result = string.IsNullOrWhiteSpace(zipCode) ? null :
                         await service.Get(zipCode);
            return Ok(result);
        }

        [HttpGet("{uf}/{city}/{address}")]
        public async Task<IActionResult> GetAddress(string uf, string city, string address)
        {
            var isInvalid = string.IsNullOrWhiteSpace(uf) ||
                          string.IsNullOrWhiteSpace(city) ||
                          string.IsNullOrWhiteSpace(address);

            var result = isInvalid ? null :
                         await service.Get(uf, city, address);

            return Ok(result);
        }
    }
}
