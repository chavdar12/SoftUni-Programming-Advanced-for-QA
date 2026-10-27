namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex001_ReversesEachWordUntilEnd()
    {
        var output = ConsoleRunner.Run("Ex001", "helLo", "Softuni", "bottle", "end");

        Assert.That(output, Is.EqualTo("helLo = oLleh\nSoftuni = inutfoS\nbottle = elttob"));
    }
}
