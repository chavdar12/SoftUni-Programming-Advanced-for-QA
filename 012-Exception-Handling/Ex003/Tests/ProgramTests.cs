namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex003_SumsOnlyValidIntegers()
    {
        var output = ConsoleRunner.Run("Ex003", "1 abc 999999999999 2");

        Assert.That(output, Is.EqualTo(
            "Element '1' processed - current sum: 1\n" +
            "The element 'abc' is in wrong format!\n" +
            "Element 'abc' processed - current sum: 1\n" +
            "The element '999999999999' is out of range!\n" +
            "Element '999999999999' processed - current sum: 1\n" +
            "Element '2' processed - current sum: 3\n" +
            "The total sum of all integers is: 3"));
    }
}
