namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex001_CountsCharsIgnoringSpaces()
    {
        Assert.That(ConsoleRunner.Run("Ex001", "te xt"), Is.EqualTo("t -> 2\ne -> 1\nx -> 1"));
    }
}
