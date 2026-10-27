namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex001_CountsRealNumbersSorted()
    {
        Assert.That(ConsoleRunner.Run("Ex001", "8 2.5 2.5 8 2.5"), Is.EqualTo("2.5 -> 3\n8 -> 2"));
    }
}
