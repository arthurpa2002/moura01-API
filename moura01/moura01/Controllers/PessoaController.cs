using Microsoft.AspNetCore.Mvc;
using moura01.models;

namespace moura01.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class PessoaController : ControllerBase
    {
        private static List<Pessoa> pessoas = [];

    
        [HttpGet(Name = "pessoas")]
        public IEnumerable<Pessoa> GetAll()
        {
            

            return pessoas ;

              
        }

        [HttpPost(Name = "pessoa")]
        public IActionResult Post(Pessoa pessoa)
        {
            if (pessoa == null)
            {
                return BadRequest("Pessoa invalida");
            } 
            pessoas.Add (pessoa);
            return Ok(pessoa);
        }
    }
}
