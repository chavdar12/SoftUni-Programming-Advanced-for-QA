using Ex001;

namespace Tests;

public class ProgramTests
{
    [Test]
    public void Test_Ex001_PrintsMenuAndOrderHistory()
    {
        Assert.That(ConsoleRunner.Run("Ex001"), Is.EqualTo(
            "Menu Items:\n" +
            "Main Course: Pasta - Delicious pasta dish - $12.99\n" +
            "Appetizer: Salad - Fresh garden salad - $7.99\n" +
            "Dessert: Cheesecake - Creamy cheesecake - $5.99\n" +
            "John Doe's Order History:\n" +
            "Order Total: $18.98\n" +
            " Main Course: Pasta - Delicious pasta dish - $12.99\n" +
            " Dessert: Cheesecake - Creamy cheesecake - $5.99"));
    }

    [Test]
    public void Test_Order_GetTotal_SumsItemPrices()
    {
        Order order = new();
        order.AddItem(new AppetizerMenuItem("Soup", "Hot", 4.50m));
        order.AddItem(new DessertMenuItem("Cake", "Sweet", 3.25m));

        Assert.That(order.GetTotal(), Is.EqualTo(7.75m));
    }

    [TestCase(-1)]
    [TestCase(1)]
    public void Test_Restaurant_GetMenuItem_InvalidIndex_Throws(int index)
    {
        Restaurant restaurant = new();
        restaurant.AddMenuItem(new DessertMenuItem("Cake", "Sweet", 3.25m));

        Assert.That(() => restaurant.GetMenuItem(index), Throws.InstanceOf<IndexOutOfRangeException>());
    }
}
