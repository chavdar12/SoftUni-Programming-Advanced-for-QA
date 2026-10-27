namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex002_RejectsInvalidAndOutOfRangeNumbers()
    {
        var output = ConsoleRunner.Run("Ex002", "2", "abc", "1", "3", "4", "5", "6", "7", "8", "9", "10", "11");

        Assert.That(output, Is.EqualTo(
            "Invalid Number!\nYour number is not in range 2 - 100!\n2, 3, 4, 5, 6, 7, 8, 9, 10, 11"));
    }
}
