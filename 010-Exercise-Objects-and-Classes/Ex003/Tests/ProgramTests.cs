namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex003_CreatesTeamsAndDisbandsEmptyOnes()
    {
        var output = ConsoleRunner.Run("Ex003", "2", "Didi-PowerPuffsCoders", "Toni-Toni is the best",
            "Petq->PowerPuffsCoders", "Toni->Toni is the best", "end of assignment");

        Assert.That(output, Is.EqualTo(
            "Team PowerPuffsCoders has been created by Didi!\n" +
            "Team Toni is the best has been created by Toni!\n" +
            "Member Toni cannot join team Toni is the best!\n" +
            "PowerPuffsCoders\n- Didi\n-- Petq\n" +
            "Teams to disband:\nToni is the best"));
    }
}
