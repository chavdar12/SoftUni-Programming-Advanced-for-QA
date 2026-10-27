namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex004_AwardsBadgesAndDamagesPokemons()
    {
        var output = ConsoleRunner.Run("Ex004", "Peter Charizard Fire 100", "George Squirtle Water 38",
            "Peter Pikachu Electricity 10", "Tournament", "Fire", "Electricity", "End");

        Assert.That(output, Is.EqualTo("Peter 2 2\nGeorge 0 1"));
    }
}
