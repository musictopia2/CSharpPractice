namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson03ConsoleReadLine.Exercise05;
public static class MainClass
{
    public static void CheckInVisitor()
    {
        Console.Write("Visitor: ");
        string visitor = Console.ReadLine()!;
        Console.WriteLine(visitor);
        Console.WriteLine("Check-in complete.");
    }
}