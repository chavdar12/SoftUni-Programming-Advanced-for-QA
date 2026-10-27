namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex004_RegistersAndUnregistersUsers()
    {
        var output = ConsoleRunner.Run("Ex004", "5",
            "register John CS1234JS", "register John AB0000AB", "unregister Bob",
            "register Andy AB4142CD", "unregister Andy");

        Assert.That(output, Is.EqualTo(
            "John registered CS1234JS successfully\n" +
            "ERROR: already registered with plate number CS1234JS\n" +
            "ERROR: user Bob not found\n" +
            "Andy registered AB4142CD successfully\n" +
            "Andy unregistered successfully\n" +
            "John => CS1234JS"));
    }
}
