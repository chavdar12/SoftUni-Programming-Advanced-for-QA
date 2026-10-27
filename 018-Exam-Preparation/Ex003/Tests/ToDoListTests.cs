using TestApp.Todo;

namespace Tests;

public class ToDoListTests
{
    private static readonly DateTime DueDate = new(2024, 1, 15);
    private ToDoList _toDoList = null!;

    [SetUp]
    public void SetUp()
    {
        _toDoList = new ToDoList();
    }

    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        _toDoList.AddTask("Buy milk", DueDate);

        Assert.That(_toDoList.DisplayTasks(),
            Is.EqualTo($"To-Do List:{Environment.NewLine}[ ] Buy milk - Due: 01/15/2024"));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted_IgnoringCase()
    {
        _toDoList.AddTask("Buy milk", DueDate);

        _toDoList.CompleteTask("BUY MILK");

        Assert.That(_toDoList.DisplayTasks(),
            Is.EqualTo($"To-Do List:{Environment.NewLine}[✓] Buy milk - Due: 01/15/2024"));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        _toDoList.AddTask("Buy milk", DueDate);

        Assert.That(() => _toDoList.CompleteTask("Walk dog"),
            Throws.ArgumentException.With.Message.EqualTo("Task with given title does not exist."));
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsOnlyHeader()
    {
        Assert.That(_toDoList.DisplayTasks(), Is.EqualTo("To-Do List:"));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        _toDoList.AddTask("Buy milk", DueDate);
        _toDoList.AddTask("Walk dog", DueDate.AddDays(1));
        _toDoList.CompleteTask("Walk dog");

        Assert.That(_toDoList.DisplayTasks(), Is.EqualTo(
            $"To-Do List:{Environment.NewLine}" +
            $"[ ] Buy milk - Due: 01/15/2024{Environment.NewLine}" +
            "[✓] Walk dog - Due: 01/16/2024"));
    }
}
