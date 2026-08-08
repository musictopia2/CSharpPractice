namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson01ConsolePrinting.Exercise02;
public static class MainClass
{
    public static void PrintShippingLabel()
    {
        string recipient = "Morgan Reed";
        string street = "42 Pine Avenue";
        string city = "Riverton";
        Console.WriteLine(recipient);
        Console.WriteLine(street);
        Console.WriteLine(city);
    }
}
