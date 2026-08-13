namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson08VarKeyword.Exercise04;
public static class MainClass
{
    public static string CreateOrderSummary(string itemName, int quantity)
    {
        var totals = quantity * 2;
        var output = $"Item: {itemName}, Total units: {totals}";
        return output;
    }
}