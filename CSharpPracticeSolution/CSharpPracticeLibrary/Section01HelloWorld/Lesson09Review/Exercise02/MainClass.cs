namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson09Review.Exercise02;
public static class MainClass
{
    private const string _language = "C#";
    /*
    This asks for your name and the current lesson.
    Which will at the end print the developer profile.
*/
    public static void PrintDeveloperProfile()
    {
        Console.Write("Enter your name: ");
        //this shows the person who was completing the lesson
        var name = Console.ReadLine()!;
        Console.Write("Enter your current lesson: ");
        string currentLesson = Console.ReadLine()!;
        Console.WriteLine($"Developer: {name}");
        Console.WriteLine($"Language: {_language}");
        Console.WriteLine($"Current Lesson: {currentLesson}");
    }
}