using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger){
            _logger=logger;
        }

    }

    [HttpGet("all")]
    public ActionResult<IEnumerable<Usuario>> GetAll(){
        return new []{
            new Usuario{ID=5,Email="email@mail.com",Password="emailmail",Name="Email Mail"}
        };
    }
}
