using TestApp;

namespace Tests;

public class CsvParserTests
{
    [TestCase(null)]
    [TestCase("")]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray(string? input)
    {
        Assert.That(CsvParser.ParseCsv(input), Is.Empty);
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        Assert.That(CsvParser.ParseCsv("apple"), Is.EqualTo(new[] { "apple" }));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        Assert.That(CsvParser.ParseCsv("apple,banana,kiwi"), Is.EqualTo(new[] { "apple", "banana", "kiwi" }));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        Assert.That(CsvParser.ParseCsv("  apple , green banana ,kiwi  "),
            Is.EqualTo(new[] { "apple", "green banana", "kiwi" }));
    }

    [Test]
    public void Test_ParseCsv_EmptyFields_AreKept()
    {
        Assert.That(CsvParser.ParseCsv("a,,b"), Is.EqualTo(new[] { "a", "", "b" }));
    }
}
