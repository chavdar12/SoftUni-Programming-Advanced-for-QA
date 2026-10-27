namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex004_PrintsEvenLengthWords()
    {
        Assert.That(ConsoleRunner.Run("Ex004", "kiwi orange banana apple"), Is.EqualTo("kiwi\norange\nbanana"));
    }
}
