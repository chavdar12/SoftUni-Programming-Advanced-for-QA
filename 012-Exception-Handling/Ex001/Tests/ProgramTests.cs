namespace Tests;

public class ProgramTests
{
    [TestCase("9", "3\nGoodbye.")]
    [TestCase("-1", "Invalid number.\nGoodbye.")]
    public void Test_Ex001_PrintsSquareRootOrError(string input, string expected)
    {
        Assert.That(ConsoleRunner.Run("Ex001", input), Is.EqualTo(expected));
    }
}
