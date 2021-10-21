using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/v1/pasteldefrango")]
    public class PastelDeFrangoController : ControllerBase
    {
        [HttpPut("salvar")]
        public String Salvar()
        {
            return "pasteldefrango salvou";
        }

        [HttpDelete("excluir")]
        public String Excluir()
        {
            return "pasteldefrango excluiu";
        }
    }
}
