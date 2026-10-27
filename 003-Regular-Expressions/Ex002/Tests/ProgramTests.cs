namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex002_MatchesOnlyValidSofiaPhoneNumbers()
    {
        var output = ConsoleRunner.Run("Ex002",
            "+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222");

        Assert.That(output, Is.EqualTo("+359 2 222 2222, +359-2-222-2222"));
    }
}
