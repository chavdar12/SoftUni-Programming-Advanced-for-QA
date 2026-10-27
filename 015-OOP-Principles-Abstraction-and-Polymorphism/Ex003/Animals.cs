namespace Ex003;

public abstract class Animal
{
    protected Animal(string name, string favouriteFood)
    {
        Name = name;
        FavouriteFood = favouriteFood;
    }

    public string Name { get; }

    public string FavouriteFood { get; }

    public virtual string ExplainSelf()
    {
        return $"I am {Name} and my favourite food is {FavouriteFood}";
    }
}

public class Cat : Animal
{
    public Cat(string name, string favouriteFood) : base(name, favouriteFood)
    {
    }

    public override string ExplainSelf()
    {
        return base.ExplainSelf() + Environment.NewLine + "MEEOW";
    }
}

public class Dog : Animal
{
    public Dog(string name, string favouriteFood) : base(name, favouriteFood)
    {
    }

    public override string ExplainSelf()
    {
        return base.ExplainSelf() + Environment.NewLine + "BORK";
    }
}
