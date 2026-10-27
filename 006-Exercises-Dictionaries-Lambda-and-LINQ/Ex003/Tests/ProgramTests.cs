namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex003_UsesLatestPriceAndTotalQuantity()
    {
        var output = ConsoleRunner.Run("Ex003",
            "Beer 2.40 350", "Water 1.25 200", "IceTea 5.20 100", "Beer 1.20 200", "IceTea 0.50 120", "buy");

        Assert.That(output, Is.EqualTo("Beer -> 660.00\nWater -> 250.00\nIceTea -> 110.00"));
    }
}
