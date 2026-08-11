namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson03ConsoleReadLine.Exercise04;
public static class MainClass
{
    public static void PrintUsername()
    {
        Console.Write("Username: ");
        string userName = Console.ReadLine()!;
        Console.WriteLine(userName);
    }
}