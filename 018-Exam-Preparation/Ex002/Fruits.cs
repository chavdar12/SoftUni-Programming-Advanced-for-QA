namespace TestApp;

public class Fruits
{
    public static int GetFruitQuantity(Dictionary<string, int>? fruitDictionary, string? fruitName)
    {
        if (fruitDictionary is null || fruitName is null) return 0;

        return fruitDictionary.TryGetValue(fruitName, out var quantity) ? quantity : 0;
    }
}
