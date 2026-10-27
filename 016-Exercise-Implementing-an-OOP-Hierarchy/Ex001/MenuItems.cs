namespace Ex001;

public abstract class MenuItem
{
    protected MenuItem(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }

    public string Name { get; }

    public string Description { get; }

    public decimal Price { get; }

    public override string ToString()
    {
        return $"{Name} - {Description} - ${Price}";
    }
}

public class AppetizerMenuItem : MenuItem
{
    public AppetizerMenuItem(string name, string description, decimal price) : base(name, description, price)
    {
    }

    public override string ToString()
    {
        return $"Appetizer: {base.ToString()}";
    }
}

public class MainCourseMenuItem : MenuItem
{
    public MainCourseMenuItem(string name, string description, decimal price) : base(name, description, price)
    {
    }

    public override string ToString()
    {
        return $"Main Course: {base.ToString()}";
    }
}

public class DessertMenuItem : MenuItem
{
    public DessertMenuItem(string name, string description, decimal price) : base(name, description, price)
    {
    }

    public override string ToString()
    {
        return $"Dessert: {base.ToString()}";
    }
}
