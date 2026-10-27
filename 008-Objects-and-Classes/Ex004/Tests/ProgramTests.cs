namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex004_PrintsCatalogueSortedByBrand()
    {
        var output = ConsoleRunner.Run("Ex004",
            "Car/Maserati/Levante/350", "Truck/Mercedes/Actros/9019", "Car/Audi/A3/110", "end");

        Assert.That(output, Is.EqualTo(
            "Cars:\nAudi: A3 - 110hp\nMaserati: Levante - 350hp\nTrucks:\nMercedes: Actros - 9019kg"));
    }

    [Test]
    public void Test_Ex004_SkipsEmptySections()
    {
        Assert.That(ConsoleRunner.Run("Ex004", "Car/Audi/A3/110", "end"), Is.EqualTo("Cars:\nAudi: A3 - 110hp"));
    }
}
