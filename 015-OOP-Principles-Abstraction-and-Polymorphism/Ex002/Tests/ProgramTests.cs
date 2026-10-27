namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex002_PrintsSeatAndTesla()
    {
        Assert.That(ConsoleRunner.Run("Ex002"), Is.EqualTo(
            "Grey Seat Leon\nEngine start\nBreak!\n" +
            "Red Tesla Model 3 with 2 Batteries\nEngine start\nBreak!"));
    }
}
