using Microsoft.AspNetCore.Mvc;
using TaskOne.models;
using TaskOne.services;

namespace TaskOne.controller;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{

    private TodoService _todoService;
    public TaskController(TodoService todoService)
    {
        _todoService = todoService;
    }
    
    [HttpGet("{id?}")]
    public IActionResult GetTasks(int? id)
    {
        var allTodos = _todoService.GetAllTodos();
        if (id is null) return Ok(allTodos);
        allTodos = allTodos.Where(t => t.Id == id).ToList();
        return Ok(allTodos);
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
        if (isBool) return BadRequest();
        return Ok();
    }
}