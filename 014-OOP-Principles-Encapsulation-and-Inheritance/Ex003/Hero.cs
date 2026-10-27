namespace Ex003;

public class Hero
{
    public Hero(string username, int level)
    {
        Username = username;
        Level = level;
    }

    public string Username { get; set; }

    public int Level { get; set; }

    public override string ToString()
    {
        return $"Type: {GetType().Name} Username: {Username} Level: {Level}";
    }
}

public class Elf : Hero
{
    public Elf(string username, int level) : base(username, level)
    {
    }
}

public class MuseElf : Elf
{
    public MuseElf(string username, int level) : base(username, level)
    {
    }
}

public class Knight : Hero
{
    public Knight(string username, int level) : base(username, level)
    {
    }
}

public class DarkKnight : Knight
{
    public DarkKnight(string username, int level) : base(username, level)
    {
    }
}

public class BladeKnight : DarkKnight
{
    public BladeKnight(string username, int level) : base(username, level)
    {
    }
}
