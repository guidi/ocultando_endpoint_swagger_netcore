using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/v1/pasteldecarne")]
    public class PastelDeCarneController : ControllerBase
    {
        [HttpPut("salvar")]
        public String Salvar()
        {
            return "pasteldecarne salvou";
        }

        [HttpDelete("excluir")]
        public String Excluir()
        {
            return "pasteldecarne excluiu";
        }
    }
}
