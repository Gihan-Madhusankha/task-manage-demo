using Microsoft.AspNetCore.Mvc;

namespace TaskOne.controller;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpGet]
    public IActionResult GetTasks()
    {
        var tasks = new string[]{"Task 1", "Task 2", "Task 3"};
        return Ok(tasks);
    }

    [HttpPost]
    public IActionResult SaveTask()
    {
        return Ok();
    }
    
    
    [HttpPut]
    public IActionResult UpdateTask()
    {
        return Ok();
    }
    
    
    [HttpDelete]
    public IActionResult DeleteTask()
    {
        var isBool = true;
        if ( isBool)
        {
            return BadRequest();
        }
        return Ok();
    }
}

