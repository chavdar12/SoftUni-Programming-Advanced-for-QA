namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex001_MatchesFullNames()
    {
        var output = ConsoleRunner.Run("Ex001",
            "Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan\tIvanov");

        Assert.That(output, Is.EqualTo("Ivan Ivanov Test Testov"));
    }
}
