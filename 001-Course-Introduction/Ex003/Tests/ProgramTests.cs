namespace Tests;

public class ProgramTests
{
    [TestCase("Ex003")]
    public void Test_Program_PrintsHelloWorld(string program)
    {
        Assert.That(ConsoleRunner.Run(program), Is.EqualTo("Hello, World!"));
    }
}
