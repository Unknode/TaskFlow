using Microsoft.AspNetCore.Mvc;
using TaskFlow.Application.DTO;

namespace TaskFlow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateTask([FromBody] TaskDTO task)
        {
            if (task == null)
                return UnprocessableEntity();

            return Ok(task);
        }

        [HttpGet("{id}")]
        public IActionResult GetTask(string id)
        {
            if (id == null)
                return NotFound();

            if (int.TryParse(id, out var taskId))
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public IActionResult GetTasks()
        {
            return NotFound();
        }

        [HttpPut]
        public IActionResult UpdateTask([FromBody] TaskDTO task)
        {
            if (task == null)
                return UnprocessableEntity();

            return Ok(task);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(string id)
        {
            if (id == null)
                return NotFound();

            if (int.TryParse(id, out var taskId))
            {
                return Ok();
            }

            return BadRequest();
        }

    }
}
