namespace CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise05;
public static class MainClass
{
    public static void Main()
    {
        DisplayOrderSummary("Morgan", 12, 84.75m);
    }
    public static void DisplayOrderSummary(
    string customerName,
    int itemCount,
    decimal totalCost)
    {
        Console.WriteLine($"Customer: {customerName}");
        Console.WriteLine($"Items: {itemCount}");
        Console.WriteLine($"Total: {totalCost.ToCurrency()}");
    }
}