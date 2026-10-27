namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex002_PrintsStudentsFromCity()
    {
        var output = ConsoleRunner.Run("Ex002",
            "John Smith 15 Sofia", "Peter Ivanov 14 Plovdiv", "Linda Bridge 16 Sofia", "end", "Sofia");

        Assert.That(output, Is.EqualTo("John Smith is 15 years old.\nLinda Bridge is 16 years old."));
    }
}
