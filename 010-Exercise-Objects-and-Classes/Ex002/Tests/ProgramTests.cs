namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex002_AppliesArticleCommands()
    {
        var output = ConsoleRunner.Run("Ex002", "some title, some content, some author", "3",
            "Edit: better content", "ChangeAuthor: better author", "Rename: better title");

        Assert.That(output, Is.EqualTo("better title - better content: better author"));
    }
}
