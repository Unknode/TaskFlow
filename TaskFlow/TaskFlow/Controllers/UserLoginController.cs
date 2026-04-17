using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskFlow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetLogin([FromBody] User user)
        {
            return Ok();
        }
    }
}
