namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson03ConsoleReadLine.Exercise03;
public static class MainClass
{
    public static void PrintHobby()
    {
        Console.WriteLine("Hobby selected:");
        string hobby = Console.ReadLine()!;
        Console.WriteLine(hobby);
        Console.WriteLine("Enjoy your hobby!");
    }
}