namespace CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise04;
public static class MainClass
{
    public static void PrepareShipment(int packageCount)
    {
        Console.WriteLine($"Packages: {packageCount}");
        if (packageCount is > 10)
        {
            PrintLargeShipmentWarning();
        }
    }
    private static void PrintLargeShipmentWarning()
    {
        Console.WriteLine("Large shipment requires inspection.");
    }
}