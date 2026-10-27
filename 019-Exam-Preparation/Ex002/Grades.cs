using System.Text;

namespace TestApp;

public class Grades
{
    public static string GetBestStudents(Dictionary<string, int> grades)
    {
        StringBuilder sb = new();
        foreach (var pair in grades.OrderByDescending(p => p.Value).ThenBy(p => p.Key).Take(3))
            sb.AppendLine($"{pair.Key} with average grade {pair.Value:f2}");

        return sb.ToString().Trim();
    }
}
