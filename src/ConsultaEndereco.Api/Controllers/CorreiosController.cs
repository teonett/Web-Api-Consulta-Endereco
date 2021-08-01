using ConsultaEndereco.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ConsultaEndereco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorreiosController : ControllerBase
    {
        private readonly ICorreiosService service;

        public CorreiosController(ICorreiosService service)
        {
            this.service = service;
        }

        [HttpGet("{zipCodeAddress}")]
        public async Task<IActionResult> Get(string zipCodeAddress)
        {
            var result = string.IsNullOrWhiteSpace(zipCodeAddress) ? null : 
                         await service.Get(zipCodeAddress);
            return Ok(result);
        }
    }
}
