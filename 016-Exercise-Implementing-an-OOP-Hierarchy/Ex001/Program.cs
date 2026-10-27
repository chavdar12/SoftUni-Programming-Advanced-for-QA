namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        Restaurant restaurant = new();

        restaurant.AddMenuItem(new MainCourseMenuItem("Pasta", "Delicious pasta dish", 12.99m));
        restaurant.AddMenuItem(new AppetizerMenuItem("Salad", "Fresh garden salad", 7.99m));
        restaurant.AddMenuItem(new DessertMenuItem("Cheesecake", "Creamy cheesecake", 5.99m));

        Customer customer1 = new("John Doe", "john.doe@example.com");
        Customer customer2 = new("Jane Smith", "jane.smith@example.com");
        restaurant.AddCustomer(customer1);
        restaurant.AddCustomer(customer2);

        Order order = new();
        order.AddItem(restaurant.GetMenuItem(0));
        order.AddItem(restaurant.GetMenuItem(2));
        restaurant.PlaceOrder(customer1, order);

        restaurant.DisplayMenu();
        restaurant.DisplayOrderHistory(customer1);
    }
}
