using Microsoft.AspNetCore.Mvc;
using salao.API.Business;
using salao.API.Model;

namespace salao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoController : ControllerBase
    {
        private CalculoBusiness user { get; set; }
        public CalculoController()
        {
            user = new CalculoBusiness();
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("dados do usuário");
        }
        [HttpPost]
        public ActionResult Calcula([FromBody] CalculaItem item)
        {
            var retorno = user.Calcula(item);
            if(retorno == null)
            {
                return BadRequest("Operação inválida");
            }
            else
            {
                return Ok(retorno);
            }
        }

    }
}
