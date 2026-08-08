namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson01ConsolePrinting.Exercise03;
public static class MainClass
{
    public static void PrintStoreHours()
    {
        string storeName = "Northside Books";
        string weekdayHours = "Monday-Friday: 9 AM - 6 PM";
        string weekendHours = "Saturday: 10 AM - 4 PM";
        Console.WriteLine(storeName);
        Console.WriteLine(weekdayHours);
        Console.WriteLine(weekendHours);
    }
}