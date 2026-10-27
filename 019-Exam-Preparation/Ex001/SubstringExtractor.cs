namespace TestApp;

public class SubstringExtractor
{
    public static string ExtractSubstringBetweenMarkers(string input, string startMarker, string endMarker)
    {
        if (string.IsNullOrEmpty(input)) return "Substring not found";

        var startIndex = input.IndexOf(startMarker, StringComparison.Ordinal);
        if (startIndex == -1) return "Substring not found";

        var contentStart = startIndex + startMarker.Length;
        var endIndex = input.IndexOf(endMarker, contentStart, StringComparison.Ordinal);
        if (endIndex == -1) return "Substring not found";

        return input.Substring(contentStart, endIndex - contentStart);
    }
}
