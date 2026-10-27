namespace TestApp;

public class CsvParser
{
    public static string[] ParseCsv(string? csvData)
    {
        if (string.IsNullOrEmpty(csvData)) return Array.Empty<string>();

        return csvData.Split(',', StringSplitOptions.TrimEntries);
    }
}
