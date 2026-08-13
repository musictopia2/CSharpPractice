namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson09Review.Exercise03;
public static class MainClass
{
    public const string _practiceName = "C# Practice Tracker";
    /*
    This method asks for user name, practice topic, and session status.

    Prints the results of what is entered and shows the pracice name
*/
    public static void PrintPracticeSession()
    {
        //shows the person using it.
        Console.Write("Enter your name: ");
        string name = Console.ReadLine()!;
        Console.Write("Enter the practice topic: ");
        string topic = Console.ReadLine()!;
        Console.Write("Enter the session status: ");
        var status = Console.ReadLine()!;
        Console.WriteLine($"Program: {_practiceName}");
        Console.WriteLine($"Student: {name}");
        Console.WriteLine($"Topic: {topic}");
        Console.WriteLine($"Session Status: {status}");
    }
}