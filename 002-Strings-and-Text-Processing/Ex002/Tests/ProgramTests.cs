namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex002_RepeatsEachWordByItsLength()
    {
        Assert.That(ConsoleRunner.Run("Ex002", "hi abc add"), Is.EqualTo("hihiabcabcabcaddaddadd"));
    }
}
