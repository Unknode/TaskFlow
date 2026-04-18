using Microsoft.AspNetCore.Mvc;
using TaskFlow.Application.DTO;

namespace TaskFlow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetLogin([FromBody] UserDTO user)
        {
            return Ok();
        }
    }
}
