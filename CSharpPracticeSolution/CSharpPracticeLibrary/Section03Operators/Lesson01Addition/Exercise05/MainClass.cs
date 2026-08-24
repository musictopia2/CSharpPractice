namespace CSharpPracticeLibrary.Section03Operators.Lesson01Addition.Exercise05;
public static class MainClass
{
    public static string CreateOrderSummary(string customerName, int existingItems, int newItems)
    {
        int totalItems = existingItems + newItems;
        return $"Customer: {customerName} | Total Items: {totalItems}";
    }
}