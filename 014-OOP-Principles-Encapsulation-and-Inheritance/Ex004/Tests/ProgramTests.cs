namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex004_AnimalsKnowTheirParentClass()
    {
        Assert.That(ConsoleRunner.Run("Ex004"), Is.EqualTo(
            "Kong is a Gorilla (Mammal)\nBaloo is a Bear (Mammal)\nRex is a Lizard (Reptile)\nKaa is a Snake (Reptile)"));
    }
}
