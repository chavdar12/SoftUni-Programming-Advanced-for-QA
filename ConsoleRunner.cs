using System.Reflection;

/// <summary>Runs a referenced console project's Main with fake stdin and returns its stdout.</summary>
internal static class ConsoleRunner
{
    public static string Run(string assemblyName, params string[] inputLines)
    {
        var originalIn = Console.In;
        var originalOut = Console.Out;
        var output = new StringWriter();
        try
        {
            Console.SetIn(new StringReader(string.Join("\n", inputLines)));
            Console.SetOut(output);
            Assembly.Load(assemblyName).EntryPoint!.Invoke(null, new object[] { Array.Empty<string>() });
        }
        finally
        {
            Console.SetIn(originalIn);
            Console.SetOut(originalOut);
        }

        return output.ToString().ReplaceLineEndings("\n").TrimEnd();
    }
}
