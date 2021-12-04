using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskItemController : ControllerBase
{
    private static readonly TaskItem[] TaskItems = new TaskItem[] {
        new("Clean the floor", "Disgusting"),
        new("Make some Tee", "I love tee"),
        new("And some cofee", "Cofee is better though"),
    };

    private readonly ILogger<TaskItemController> _logger;

    public TaskItemController(ILogger<TaskItemController> logger)
    {
        _logger = logger;
    }

    [HttpGet("All")]
    public IEnumerable<TaskItem> Get()
    {
        _logger.LogInformation("asdf");
        return TaskItems
            .ToArray();
    }
}
