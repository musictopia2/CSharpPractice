namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson09Review.Exercise01;
public static class MainClass
{
    public const string CourseName = "C# Fundamentals";
    /*
    This is a method that shows 3 pieces of information.
    This will print what the status of the practice project is.
    Prints the course name, how many lessons was completed and showing the status.
*/
    public static void PrintPracticeStatus()
    {
        //the completed lessons represents how many lessons was completed in this section.
        int completedLessons = 8;
        var status = "Section Complete";
        Console.WriteLine($"Course: {CourseName}");
        Console.WriteLine($"Lessons Completed: {completedLessons}");
        Console.WriteLine($"Status: {status}");
    }
    

}