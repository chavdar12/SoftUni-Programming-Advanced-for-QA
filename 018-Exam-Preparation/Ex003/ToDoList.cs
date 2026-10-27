using System.Text;

namespace TestApp.Todo;

public class ToDoList
{
    private readonly List<TaskItem> _tasks = new();

    public void AddTask(string title, DateTime dueDate)
    {
        _tasks.Add(new TaskItem(title, dueDate));
    }

    public void CompleteTask(string title)
    {
        var task = _tasks.FirstOrDefault(t => t.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (task is null) throw new ArgumentException("Task with given title does not exist.");

        task.IsCompleted = true;
    }

    public string DisplayTasks()
    {
        StringBuilder sb = new();
        sb.AppendLine("To-Do List:");
        foreach (var task in _tasks)
            sb.AppendLine($"{(task.IsCompleted ? "[✓]" : "[ ]")} {task.Title} - Due: {task.DueDate:MM/dd/yyyy}");

        return sb.ToString().Trim();
    }
}
