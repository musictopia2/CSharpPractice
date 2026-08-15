namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson05StringConcatenation.Exercise05;
public static class MainClass
{
    public static void PrintDeliveryConfirmation(string customerName, string itemName, int quantity)
    {
        Console.WriteLine("Customer: " + customerName);
        Console.WriteLine("Item: " + itemName);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Delivery ready: " + quantity + " " + itemName + " for " + customerName + ".");
    }
}