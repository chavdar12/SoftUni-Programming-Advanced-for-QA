namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex002_SortsPeopleByFirstNameThenAge()
    {
        var output = ConsoleRunner.Run("Ex002", "4", "Peter Johnson 25", "Anna Smith 30", "Peter Black 20",
            "Bobby Brown 40");

        Assert.That(output, Is.EqualTo(
            "Anna Smith is 30 years old.\n" +
            "Bobby Brown is 40 years old.\n" +
            "Peter Black is 20 years old.\n" +
            "Peter Johnson is 25 years old."));
    }

    [TestCase("Al", "Smith", 30, "First name cannot contain fewer than 3 symbols!")]
    [TestCase("Anna", "Sm", 30, "Last name cannot contain fewer than 3 symbols!")]
    [TestCase("Anna", "Smith", 0, "Age cannot be zero or a negative integer!")]
    public void Test_Ex002_Person_InvalidData_Throws(string firstName, string lastName, int age, string message)
    {
        Assert.That(() => new Ex002.Person(firstName, lastName, age),
            Throws.ArgumentException.With.Message.EqualTo(message));
    }
}
