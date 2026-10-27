namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex001_PrintsBoxSurfaceAreaAndVolume()
    {
        Assert.That(ConsoleRunner.Run("Ex001", "2", "3", "4"), Is.EqualTo("Surface Area - 52.00\nVolume - 24.00"));
    }

    [TestCase("0", "3", "4", "Length cannot be zero or negative.")]
    [TestCase("2", "-3", "4", "Width cannot be zero or negative.")]
    [TestCase("2", "3", "0", "Height cannot be zero or negative.")]
    public void Test_Ex001_InvalidSide_PrintsError(string length, string width, string height, string expected)
    {
        Assert.That(ConsoleRunner.Run("Ex001", length, width, height), Is.EqualTo(expected));
    }
}
