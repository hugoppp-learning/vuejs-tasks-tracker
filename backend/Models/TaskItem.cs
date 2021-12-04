namespace backend.Models;
public class TaskItem
{
    public string Description { get; set; }

    public string Title { get; set; }

    public Guid Id { get; set; }

    public TaskItem(string title, string description)
    {
        Description = description;
        Title = title;
        Id = Guid.NewGuid();
    }

}
