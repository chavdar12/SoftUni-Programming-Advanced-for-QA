using Ex001;

namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex001_LamborghiniRunsOutOfFuelOnEveryTrip()
    {
        var notEnough = "Not enough fuel to perform this trip!";

        Assert.That(ConsoleRunner.Run("Ex001"), Is.EqualTo($"{notEnough}\n{notEnough}\n{notEnough}\n250"));
    }

    [Test]
    public void Test_Drive_EnoughFuel_ReducesFuelQuantity()
    {
        var car = new Car("VW", "Golf", 2025, 100, 10);

        car.Drive(5);

        Assert.That(car.FuelQuantity, Is.EqualTo(50));
    }

    [Test]
    public void Test_DefaultCar_WhoAmI_ReturnsDefaults()
    {
        Assert.That(new Car().WhoAmI(), Is.EqualTo(
            $"Make: VW{Environment.NewLine}Model: Golf{Environment.NewLine}Year: 2025{Environment.NewLine}Fuel: 200.00"));
    }
}
