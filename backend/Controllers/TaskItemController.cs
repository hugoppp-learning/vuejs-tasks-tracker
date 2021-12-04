using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskItemController : ControllerBase
{
    private static readonly List<TaskItem> TaskItems = new List<TaskItem>() {
        new ("Clean the floor", "Disgusting"),
        new ("Make some Tee", "I love tee"),
        new ("And some coffee", "Coffee is better though"),
    };

    private readonly ILogger<TaskItemController> _logger;

    public TaskItemController(ILogger<TaskItemController> logger)
    {
        _logger = logger;
    }

    [HttpGet("All")]
    public IEnumerable<TaskItem> Get()
    {
        _logger.LogInformation($"getting all");
        return TaskItems.ToArray();
    }

    [HttpDelete("{guid}")]
    public IActionResult Delete(Guid guid)
    {
        _logger.LogInformation($"removing {guid}");
        TaskItems.RemoveAll(x => x.Id == guid);
        return Ok(); ;
    }

    [HttpPut()]
    public IActionResult Put(TaskItem task)
    {
        _logger.LogInformation($"Putting {task}");
        TaskItems.Add(task);
        return Ok();
    }

}
