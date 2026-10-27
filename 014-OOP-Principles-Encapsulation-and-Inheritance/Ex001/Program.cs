namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var length = double.Parse(Console.ReadLine()!);
        var width = double.Parse(Console.ReadLine()!);
        var height = double.Parse(Console.ReadLine()!);

        try
        {
            Console.WriteLine(new Box(length, width, height));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
