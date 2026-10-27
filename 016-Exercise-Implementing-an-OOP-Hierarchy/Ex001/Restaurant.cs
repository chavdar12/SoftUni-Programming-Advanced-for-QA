using System.Text;

namespace Ex001;

public class Order
{
    private readonly List<MenuItem> _items = new();

    public IReadOnlyCollection<MenuItem> Items => _items.AsReadOnly();

    public void AddItem(MenuItem item)
    {
        _items.Add(item);
    }

    public decimal GetTotal()
    {
        return _items.Sum(i => i.Price);
    }
}

public class Customer
{
    private readonly List<Order> _orderHistory = new();

    public Customer(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public string Name { get; }

    public string Email { get; }

    public IReadOnlyCollection<Order> OrderHistory => _orderHistory.AsReadOnly();

    public void AddOrder(Order order)
    {
        _orderHistory.Add(order);
    }
}

public class Restaurant
{
    private readonly List<Customer> _customers = new();
    private readonly List<MenuItem> _menu = new();

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public void AddMenuItem(MenuItem item)
    {
        _menu.Add(item);
    }

    public MenuItem GetMenuItem(int index)
    {
        if (index < 0 || index >= _menu.Count) throw new IndexOutOfRangeException("Invalid index!");

        return _menu[index];
    }

    public void PlaceOrder(Customer customer, Order order)
    {
        customer.AddOrder(order);
    }

    public void DisplayMenu()
    {
        StringBuilder sb = new();
        sb.AppendLine("Menu Items:");
        foreach (var item in _menu) sb.AppendLine(item.ToString());

        Console.WriteLine(sb.ToString().TrimEnd());
    }

    public void DisplayOrderHistory(Customer customer)
    {
        StringBuilder sb = new();
        sb.AppendLine($"{customer.Name}'s Order History:");
        sb.AppendLine($"Order Total: ${customer.OrderHistory.Sum(o => o.GetTotal())}");
        foreach (var item in customer.OrderHistory.SelectMany(o => o.Items)) sb.AppendLine($" {item}");

        Console.WriteLine(sb.ToString().TrimEnd());
    }
}
