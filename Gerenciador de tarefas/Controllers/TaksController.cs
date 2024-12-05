using Gerenciador_de_tarefas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Gerenciador_de_tarefas.Controllers;

[Route("api/[controller]")]
[ApiController]

public class TaksController : ControllerBase
{

    private static List<TaskModel> tasks = new List<TaskModel>();
    private static int idCounter = 1;


    [HttpPost]
    public ActionResult<TaskModel> CreateTask(TaskModel task)
    {
        task.Id = idCounter++;
        tasks.Add(task);
        return CreatedAtAction(nameof(GetTask), new { id = task.Id }, task);
    }


    [HttpGet]
    public ActionResult<TaskModel> GetAllTasks()
    {
        return Ok(tasks);
    }


    [HttpGet("{id}")]
    public ActionResult<TaskModel> GetTask(int id)
    {
        var task = tasks.FirstOrDefault(task => task.Id == id);
        if (task == null)
        {
            return NotFound();
        }
        return Ok(task);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateTask(int id, TaskModel updatedTask)
    {
        var task = tasks.FirstOrDefault(task => task.Id == id);
        if (task == null)
        {
            return NotFound();
        }
        task.Name = updatedTask.Name;
        task.Description = updatedTask.Description;
        task.Status = updatedTask.Status;
        task.Priority = updatedTask.Priority;
        task.DueDate = updatedTask.DueDate;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteTask(int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if(task == null)
        {
            return NotFound();
        }
        tasks.Remove(task);
        return NoContent();
    }





}
