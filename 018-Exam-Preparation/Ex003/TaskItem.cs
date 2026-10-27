namespace TestApp.Todo;

public class TaskItem
{
    public TaskItem(string title, DateTime dueDate)
    {
        Title = title;
        DueDate = dueDate;
    }

    public string Title { get; }

    public DateTime DueDate { get; }

    public bool IsCompleted { get; set; }
}
