namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var lines = int.Parse(Console.ReadLine()!);

        List<Person> persons = new();

        for (var i = 0; i < lines; i++)
        {
            var data = Console.ReadLine()!.Split();
            persons.Add(new Person(data[0], data[1], int.Parse(data[2])));
        }

        persons
            .OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(Console.WriteLine);
    }
}
