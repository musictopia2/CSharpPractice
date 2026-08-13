namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson09Review.Exercise05;
public static class MainClass
{
    private const string _companyName = "CodeWorks Training Center";
    /*
    
*/
    public static void PrintPracticeReceipt()
    {
        //this is the name being asked.
        Console.Write("Enter learner name: ");
        var name = Console.ReadLine()!;
        Console.Write("Enter topic practiced: ");
        string topic = Console.ReadLine()!;
        Console.Write("Enter exercise completed: ");
        string exercise = Console.ReadLine()!;
        Console.Write("Enter session result: ");
        string result = Console.ReadLine()!;
        //this is the custom lines so i don't have to repeat the same code over and over for this.
        string customLines = "================================";
        Console.WriteLine(customLines);
        Console.WriteLine(_companyName);
        Console.WriteLine("PRACTICE SESSION RECEIPT");
        Console.WriteLine(customLines);
        Console.WriteLine($"Learner: {name}");
        Console.WriteLine($"Topic: {topic}");
        Console.WriteLine($"Exercise: {exercise}");
        Console.WriteLine($"Result: {result}");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Status: Session Recorded");
        Console.WriteLine(customLines);
    }
}