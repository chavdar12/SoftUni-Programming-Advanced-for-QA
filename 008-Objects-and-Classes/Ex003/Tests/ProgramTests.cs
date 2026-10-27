namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex003_OrdersBoxesByPriceDescending()
    {
        var output = ConsoleRunner.Run("Ex003", "53874549 Butter 7 3.50", "19861519 Dove 15 2.99", "end");

        Assert.That(output, Is.EqualTo(
            "19861519\n-- Dove - $2.99: 15\n-- $44.85\n53874549\n-- Butter - $3.50: 7\n-- $24.50"));
    }
}
