using TestApp.Product;

namespace Tests;

public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;

    [SetUp]
    public void SetUp()
    {
        _inventory = new ProductInventory();
    }

    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        _inventory.AddProduct("Milk", 2.5, 3);

        Assert.That(_inventory.DisplayInventory(),
            Is.EqualTo($"Product Inventory:{Environment.NewLine}Milk - Price: $2.50 - Quantity: 3"));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsOnlyHeader()
    {
        Assert.That(_inventory.DisplayInventory(), Is.EqualTo("Product Inventory:"));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        _inventory.AddProduct("Milk", 2.5, 3);
        _inventory.AddProduct("Bread", 1.199, 10);
        var expected = $"Product Inventory:{Environment.NewLine}" +
                       $"Milk - Price: $2.50 - Quantity: 3{Environment.NewLine}" +
                       "Bread - Price: $1.20 - Quantity: 10";

        // Act
        var result = _inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        Assert.That(_inventory.CalculateTotalValue(), Is.Zero);
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        _inventory.AddProduct("Milk", 2.5, 3);
        _inventory.AddProduct("Bread", 1.25, 4);

        Assert.That(_inventory.CalculateTotalValue(), Is.EqualTo(12.5));
    }
}
