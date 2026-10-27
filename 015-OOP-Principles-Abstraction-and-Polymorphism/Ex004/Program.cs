namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IHero> heroes = new();

        var n = int.Parse(Console.ReadLine()!);
        while (heroes.Count < n)
            try
            {
                heroes.Add(CreateHero());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        var bossPower = int.Parse(Console.ReadLine()!);

        heroes.ForEach(hero => Console.WriteLine(hero.CastAbility()));
        Console.WriteLine(heroes.Sum(hero => hero.Power) >= bossPower ? "Victory!" : "Defeat...");
    }

    private static IHero CreateHero()
    {
        var name = Console.ReadLine()!;
        var type = Console.ReadLine()!;

        return type switch
        {
            "Druid" => new Druid(name),
            "Paladin" => new Paladin(name),
            "Rogue" => new Rogue(name),
            "Warrior" => new Warrior(name),
            _ => throw new ArgumentException("Invalid hero!")
        };
    }
}
