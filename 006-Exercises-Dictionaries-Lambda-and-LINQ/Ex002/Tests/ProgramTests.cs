namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex002_SumsResourceQuantities()
    {
        var output = ConsoleRunner.Run("Ex002", "Gold", "155", "Silver", "10", "Copper", "17", "Gold", "15", "stop");

        Assert.That(output, Is.EqualTo("Gold -> 170\nSilver -> 10\nCopper -> 17"));
    }
}
