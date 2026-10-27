namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex003_AnimalsExplainThemselves()
    {
        Assert.That(ConsoleRunner.Run("Ex003"), Is.EqualTo(
            "I am Peter and my favourite food is Whiskas\nMEEOW\n" +
            "I am George and my favourite food is Meat\nBORK"));
    }
}
