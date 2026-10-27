namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex004_ReplacesBannedWordsWithAsterisks()
    {
        var output = ConsoleRunner.Run("Ex004", "Linux, Windows", "I use Linux and Windows");

        Assert.That(output, Is.EqualTo("I use ***** and *******"));
    }
}
