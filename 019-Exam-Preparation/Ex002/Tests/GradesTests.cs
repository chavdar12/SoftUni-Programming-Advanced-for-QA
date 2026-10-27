using TestApp;

namespace Tests;

public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new() { ["Ivan"] = 2, ["John"] = 4, ["Steve"] = 5, ["Alice"] = 3, ["Daisy"] = 6 };
        var expected = $"Daisy with average grade 6.00{Environment.NewLine}" +
                       $"Steve with average grade 5.00{Environment.NewLine}" +
                       "John with average grade 4.00";

        // Act
        var result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        Assert.That(Grades.GetBestStudents(new Dictionary<string, int>()), Is.Empty);
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        Dictionary<string, int> grades = new() { ["John"] = 4, ["Steve"] = 5 };

        Assert.That(Grades.GetBestStudents(grades),
            Is.EqualTo($"Steve with average grade 5.00{Environment.NewLine}John with average grade 4.00"));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        Dictionary<string, int> grades = new() { ["Charlie"] = 5, ["Alice"] = 5, ["Bob"] = 5, ["Anna"] = 5 };

        Assert.That(Grades.GetBestStudents(grades), Is.EqualTo(
            $"Alice with average grade 5.00{Environment.NewLine}" +
            $"Anna with average grade 5.00{Environment.NewLine}" +
            "Bob with average grade 5.00"));
    }
}
