namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex003_RemovesSubstringRepeatedly()
    {
        Assert.That(ConsoleRunner.Run("Ex003", "ice", "kicegiciceeb"), Is.EqualTo("kgb"));
    }
}
