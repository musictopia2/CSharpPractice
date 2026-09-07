namespace CSharpPracticeLibrary.Section06Methods.Lesson03ReturnValues.Exercise03;
public static class MainClass
{
    public static string CreateStockMessage(
    string itemName,
    int quantity)
    {
        return $"Item: {itemName} - Quantity: {quantity}";
    }
}