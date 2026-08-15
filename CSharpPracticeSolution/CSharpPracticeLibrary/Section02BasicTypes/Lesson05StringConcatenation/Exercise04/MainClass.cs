namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson05StringConcatenation.Exercise04;
public static class MainClass
{
    public static void PrintPracticeReport(string topic, int exercisesCompleted, int exercisesRemaining)
    {
        Console.WriteLine("Topic: " + topic);
        Console.WriteLine("Completed: " + exercisesCompleted);
        Console.WriteLine("Remaining: " + exercisesRemaining);
        Console.WriteLine("Practice progress: " + exercisesCompleted + " completed, " + exercisesRemaining + " remaining.");
    }
}