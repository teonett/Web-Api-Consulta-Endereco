﻿using ConsultaEndereco.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ConsultaEndereco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostmonController : ControllerBase
    {
        private readonly IPostmonService service;

        public PostmonController(IPostmonService service)
        {
            this.service = service;
        }

        [HttpGet("{zipCode}")]
        public async Task<IActionResult> Get(string zipCode)
        {
            long number1 = 0;
            bool canConvert = long.TryParse(zipCode, out number1);

            if (!canConvert)
                return Ok();

            var result = string.IsNullOrWhiteSpace(zipCode) ? null :
                        await service.Get(zipCode);

            return Ok(result);
        }
    }
}
