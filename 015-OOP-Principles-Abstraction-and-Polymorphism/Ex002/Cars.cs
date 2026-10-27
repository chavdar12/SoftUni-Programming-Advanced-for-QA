namespace Ex002;

public interface ICar
{
    string Model { get; }

    string Color { get; }

    string Start();

    string Stop();
}

public interface IElectricCar
{
    int Battery { get; }
}

public class Seat : ICar
{
    public Seat(string model, string color)
    {
        Model = model;
        Color = color;
    }

    public string Model { get; }

    public string Color { get; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Break!";
    }

    public override string ToString()
    {
        return $"{Color} {GetType().Name} {Model}{Environment.NewLine}{Start()}{Environment.NewLine}{Stop()}";
    }
}

public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        Model = model;
        Color = color;
        Battery = battery;
    }

    public string Model { get; }

    public string Color { get; }

    public int Battery { get; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Break!";
    }

    public override string ToString()
    {
        return $"{Color} {GetType().Name} {Model} with {Battery} Batteries{Environment.NewLine}" +
               $"{Start()}{Environment.NewLine}{Stop()}";
    }
}
