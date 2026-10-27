namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex003_MatchesDatesWithSameSeparator()
    {
        var output = ConsoleRunner.Run("Ex003",
            "13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016");

        Assert.That(output, Is.EqualTo(
            "Day: 13, Month: Jul, Year: 1928\nDay: 10, Month: Nov, Year: 1934\nDay: 25, Month: Dec, Year: 1937"));
    }
}
