namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex005_SplitsDigitsLettersAndOthers()
    {
        Assert.That(ConsoleRunner.Run("Ex005", "Agd#53Dfg^&4F53"), Is.EqualTo("53453\nAgdDfgF\n#^&"));
    }
}
