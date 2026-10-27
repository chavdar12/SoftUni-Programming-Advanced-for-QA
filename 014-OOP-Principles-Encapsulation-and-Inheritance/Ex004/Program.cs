namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Animal> animals = new() { new Gorilla("Kong"), new Bear("Baloo"), new Lizard("Rex"), new Snake("Kaa") };

        foreach (var animal in animals)
            Console.WriteLine($"{animal.Name} is a {animal.GetType().Name} ({animal.GetType().BaseType!.Name})");
    }
}
