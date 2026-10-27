namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Hero> heroes = new() { new Elf("Legolas", 10), new MuseElf("Arwen", 20), new BladeKnight("Arthur", 30) };

        heroes.ForEach(Console.WriteLine);
    }
}
