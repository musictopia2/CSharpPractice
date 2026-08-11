namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson03ConsoleReadLine.Exercise02;
public static class MainClass
{
    public static void PrintCity()
    {
        Console.WriteLine("City:");
        string city = Console.ReadLine()!;
        Console.WriteLine(city);
    }
}