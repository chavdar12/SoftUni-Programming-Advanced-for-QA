using TestApp;

namespace Tests;

public class FruitsTests
{
    private static readonly Dictionary<string, int> Basket = new() { ["apple"] = 10, ["banana"] = 5 };

    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        Assert.That(Fruits.GetFruitQuantity(Basket, "banana"), Is.EqualTo(5));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        Assert.That(Fruits.GetFruitQuantity(Basket, "kiwi"), Is.Zero);
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        Assert.That(Fruits.GetFruitQuantity(new Dictionary<string, int>(), "kiwi"), Is.Zero);
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        Assert.That(Fruits.GetFruitQuantity(null, "kiwi"), Is.Zero);
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        Assert.That(Fruits.GetFruitQuantity(Basket, null), Is.Zero);
    }
}
