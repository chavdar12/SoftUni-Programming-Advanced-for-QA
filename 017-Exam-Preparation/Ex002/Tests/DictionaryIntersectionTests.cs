using TestApp;

namespace Tests;

public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        var result = DictionaryIntersection.Intersect(new Dictionary<string, int>(), new Dictionary<string, int>());

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        var result = DictionaryIntersection.Intersect(new Dictionary<string, int>(),
            new Dictionary<string, int> { ["one"] = 1 });

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        var result = DictionaryIntersection.Intersect(new Dictionary<string, int> { ["one"] = 1 },
            new Dictionary<string, int> { ["two"] = 2 });

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new() { ["one"] = 1, ["two"] = 2, ["three"] = 3 };
        Dictionary<string, int> dict2 = new() { ["one"] = 1, ["two"] = 2, ["four"] = 4 };

        // Act
        var result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EquivalentTo(new Dictionary<string, int> { ["one"] = 1, ["two"] = 2 }));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        var result = DictionaryIntersection.Intersect(new Dictionary<string, int> { ["one"] = 1, ["two"] = 2 },
            new Dictionary<string, int> { ["one"] = 10, ["two"] = 20 });

        Assert.That(result, Is.Empty);
    }
}
