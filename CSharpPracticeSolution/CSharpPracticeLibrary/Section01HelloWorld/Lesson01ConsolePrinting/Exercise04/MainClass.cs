namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson01ConsolePrinting.Exercise04;
public static class MainClass
{
    public static void PrintContactCard()
    {
        string name = "Jordan Lee";
        string email = "jordan.lee@example.com";
        string city = "Oakridge";
        string status = "Available";
        Console.WriteLine(name);
        Console.WriteLine(status);
        Console.WriteLine(email);
        Console.WriteLine(city);
    }
}