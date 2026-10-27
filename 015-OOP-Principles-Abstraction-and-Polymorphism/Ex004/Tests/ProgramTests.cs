namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex004_HeroesWinWhenTotalPowerReachesBossPower()
    {
        var output = ConsoleRunner.Run("Ex004", "3", "Mike", "Paladin", "Josh", "Druid", "Scott", "Warrior", "280");

        Assert.That(output, Is.EqualTo(
            "Paladin - Mike healed for 100\n" +
            "Druid - Josh healed for 80\n" +
            "Warrior - Scott hit for 100 damage\n" +
            "Victory!"));
    }

    [Test]
    public void Test_Ex004_InvalidHeroIsReportedAndBossWins()
    {
        var output = ConsoleRunner.Run("Ex004", "2", "Mike", "Mage", "Mike", "Rogue", "Josh", "Druid", "200");

        Assert.That(output, Is.EqualTo(
            "Invalid hero!\n" +
            "Rogue - Mike hit for 80 damage\n" +
            "Druid - Josh healed for 80\n" +
            "Defeat..."));
    }
}
