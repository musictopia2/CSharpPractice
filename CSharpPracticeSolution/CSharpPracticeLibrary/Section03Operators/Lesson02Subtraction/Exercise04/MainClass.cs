namespace CSharpPracticeLibrary.Section03Operators.Lesson02Subtraction.Exercise04;
public static class MainClass
{
    public static string CreateInventoryReport(
    string itemName,
    int startingQuantity,
    int quantityUsed)
    {
        int totalQuantities = startingQuantity - quantityUsed;
        return $"Item: {itemName} | Remaining: {totalQuantities}";
    }
}