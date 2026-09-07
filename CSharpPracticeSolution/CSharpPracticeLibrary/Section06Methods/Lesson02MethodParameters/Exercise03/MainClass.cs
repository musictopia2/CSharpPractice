namespace CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise03;
public static class MainClass
{
    public static void Main()
    {
        DisplayProductionLabel("Bolts", 75);
    }
    public static void DisplayProductionLabel(string productName, int quantity)
    {
        Console.WriteLine($"Product: {productName} - Quantity: {quantity}");
    }
}