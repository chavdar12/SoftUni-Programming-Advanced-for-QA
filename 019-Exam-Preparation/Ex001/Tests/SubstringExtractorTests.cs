using TestApp;

namespace Tests;

public class SubstringExtractorTests
{
    private const string NotFound = "Substring not found";

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        Assert.That(SubstringExtractor.ExtractSubstringBetweenMarkers("[start]hello[end]", "[start]", "[end]"),
            Is.EqualTo("hello"));
    }

    [TestCase("hello[end]", "[start]", "[end]")]
    [TestCase("[start]hello", "[start]", "[end]")]
    [TestCase("hello", "[start]", "[end]")]
    [TestCase("", "[start]", "[end]")]
    public void Test_ExtractSubstringBetweenMarkers_MarkerMissing_ReturnsNotFoundMessage(string input, string start,
        string end)
    {
        Assert.That(SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end), Is.EqualTo(NotFound));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        Assert.That(SubstringExtractor.ExtractSubstringBetweenMarkers("123456", "123", "345"), Is.EqualTo(NotFound));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerLongerThanInput_ReturnsNotFoundMessage()
    {
        Assert.That(SubstringExtractor.ExtractSubstringBetweenMarkers("ab", "abcd", "b"), Is.EqualTo(NotFound));
    }
}
