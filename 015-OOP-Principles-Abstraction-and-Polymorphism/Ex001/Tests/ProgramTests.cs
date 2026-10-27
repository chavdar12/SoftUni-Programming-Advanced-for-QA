namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex001_DrawsCircleThenRectangle()
    {
        var expected = new[]
        {
            "   *******   ",
            " **       ** ",
            "**         **",
            "*           *",
            "**         **",
            " **       ** ",
            "   *******   ",
            "******",
            "*    *",
            "******"
        };

        Assert.That(ConsoleRunner.Run("Ex001", "3", "6", "3").Split('\n'), Is.EqualTo(expected));
    }
}
