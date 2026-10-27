namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex003_GroupsSynonymsByWord()
    {
        var output = ConsoleRunner.Run("Ex003", "3", "cute", "adorable", "cute", "charming", "smart", "clever");

        Assert.That(output, Is.EqualTo("cute - adorable, charming\nsmart - clever"));
    }
}
