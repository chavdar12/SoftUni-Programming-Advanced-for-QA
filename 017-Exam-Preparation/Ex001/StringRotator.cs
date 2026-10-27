namespace TestApp;

public class StringRotator
{
    public static string RotateRight(string input, int positions)
    {
        if (string.IsNullOrEmpty(input)) return input;

        var length = input.Length;
        positions = Math.Abs(positions) % length;

        return input.Substring(length - positions) + input.Substring(0, length - positions);
    }
}
