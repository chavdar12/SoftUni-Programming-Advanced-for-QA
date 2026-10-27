namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex006_ListsUniqueEmployeesPerCompany()
    {
        var output = ConsoleRunner.Run("Ex006",
            "SoftUni -> AA12345", "SoftUni -> BB12345", "Microsoft -> CC12345", "HP -> BB12345",
            "SoftUni -> AA12345", "End");

        Assert.That(output, Is.EqualTo("SoftUni\n-- AA12345\n-- BB12345\nMicrosoft\n-- CC12345\nHP\n-- BB12345"));
    }
}
