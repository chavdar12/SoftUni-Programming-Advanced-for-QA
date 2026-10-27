namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex002_PrintsWordsWithOddOccurrencesCaseInsensitive()
    {
        Assert.That(ConsoleRunner.Run("Ex002", "Java C# PHP PHP JAVA C java"), Is.EqualTo("java c# c"));
    }
}
