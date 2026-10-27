using System.Text;

namespace TestApp.Product;

public class ProductInventory
{
    private readonly List<Product> _products = new();

    public void AddProduct(string name, double price, int quantity)
    {
        _products.Add(new Product { Name = name, Price = price, Quantity = quantity });
    }

    public string DisplayInventory()
    {
        StringBuilder sb = new();
        sb.AppendLine("Product Inventory:");
        foreach (var product in _products)
            sb.AppendLine($"{product.Name} - Price: ${product.Price:f2} - Quantity: {product.Quantity}");

        return sb.ToString().Trim();
    }

    public double CalculateTotalValue()
    {
        return _products.Sum(product => product.Price * product.Quantity);
    }
}
