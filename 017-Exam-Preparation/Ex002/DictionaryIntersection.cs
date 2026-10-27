namespace TestApp;

public class DictionaryIntersection
{
    public static Dictionary<string, int> Intersect(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
    {
        Dictionary<string, int> intersection = new();

        foreach (var kvp in dict1)
            if (dict2.TryGetValue(kvp.Key, out var value) && value == kvp.Value)
                intersection[kvp.Key] = kvp.Value;

        return intersection;
    }
}
