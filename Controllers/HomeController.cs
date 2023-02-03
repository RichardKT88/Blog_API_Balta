using Blog.Attributes;
using Microsoft.AspNetCore.Mvc;

// Health Check ==> O Health Checks nada mais é que um middleware que nos fornecem um endpoint configurável que nos retorna o estado atual da aplicação.
namespace Blog.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        //[ApiKey]
        public IActionResult Get() 
        {
            return Ok();
        }
    }
}
