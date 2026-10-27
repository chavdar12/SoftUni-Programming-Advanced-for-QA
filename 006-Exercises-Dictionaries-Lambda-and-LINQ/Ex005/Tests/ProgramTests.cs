namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex005_PrintsStudentsWithAverageAtLeast450()
    {
        var output = ConsoleRunner.Run("Ex005", "6",
            "John", "5.5", "John", "4.5", "Alice", "6", "Alice", "3", "George", "5", "George", "3");

        Assert.That(output, Is.EqualTo("John -> 5.00\nAlice -> 4.50"));
    }
}
