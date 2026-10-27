namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex003_HeroesPrintTheirConcreteType()
    {
        Assert.That(ConsoleRunner.Run("Ex003"), Is.EqualTo(
            "Type: Elf Username: Legolas Level: 10\n" +
            "Type: MuseElf Username: Arwen Level: 20\n" +
            "Type: BladeKnight Username: Arthur Level: 30"));
    }

    [Test]
    public void Test_Ex003_BladeKnight_IsDarkKnightAndKnightAndHero()
    {
        var hero = new Ex003.BladeKnight("Arthur", 30);

        Assert.That(hero,
            Is.InstanceOf<Ex003.DarkKnight>().And.InstanceOf<Ex003.Knight>().And.InstanceOf<Ex003.Hero>());
    }
}
