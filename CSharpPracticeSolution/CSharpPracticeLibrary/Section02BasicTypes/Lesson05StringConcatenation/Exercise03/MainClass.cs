namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson05StringConcatenation.Exercise03;
public static class MainClass
{
    public static void PrintProductLabel(string productName, int quantity, double price)
    {
        Console.WriteLine("Product: " + productName);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Price: $" + price);
        Console.WriteLine(quantity + " units of " + productName + " cost $" + price + " each.");
    }
}