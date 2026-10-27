namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex001_OrdersStudentsByGradeDescending()
    {
        var output = ConsoleRunner.Run("Ex001", "3", "Lakia Eason 3.90", "Rocco Erben 6.00", "Prince Messing 5.49");

        Assert.That(output, Is.EqualTo("Rocco Erben: 6.00\nPrince Messing: 5.49\nLakia Eason: 3.90"));
    }
}
