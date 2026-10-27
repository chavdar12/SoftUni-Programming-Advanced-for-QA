namespace Ex004;

public interface IHero
{
    string Name { get; }

    int Power { get; }

    string CastAbility();
}

public abstract class BaseHero : IHero
{
    protected BaseHero(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract int Power { get; }

    public virtual string CastAbility()
    {
        return $"{GetType().Name} - {Name}";
    }
}

public abstract class Healer : BaseHero
{
    protected Healer(string name) : base(name)
    {
    }

    public override string CastAbility()
    {
        return $"{base.CastAbility()} healed for {Power}";
    }
}

public abstract class Fighter : BaseHero
{
    protected Fighter(string name) : base(name)
    {
    }

    public override string CastAbility()
    {
        return $"{base.CastAbility()} hit for {Power} damage";
    }
}

public class Druid : Healer
{
    public Druid(string name) : base(name)
    {
    }

    public override int Power => 80;
}

public class Paladin : Healer
{
    public Paladin(string name) : base(name)
    {
    }

    public override int Power => 100;
}

public class Rogue : Fighter
{
    public Rogue(string name) : base(name)
    {
    }

    public override int Power => 80;
}

public class Warrior : Fighter
{
    public Warrior(string name) : base(name)
    {
    }

    public override int Power => 100;
}
