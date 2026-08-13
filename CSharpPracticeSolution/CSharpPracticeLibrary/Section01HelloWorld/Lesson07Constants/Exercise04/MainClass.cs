namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise04;
public static class MainClass
{
    public const string ApplicationName = "Skill Builder";
    public const int ExercisesPerSession = 5;
    public static void PrintSessionSummary()
    {
        Console.WriteLine(ApplicationName);
        Console.WriteLine(ExercisesPerSession);
    }
}