namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise04;
public static class MainClass
{
    public static void PrintPracticeResult(
    string topic,
    int questions,
    int correct,
    double percentage,
    decimal timeSpent,
    char grade,
    bool passed,
    float difficulty)
    {
        Console.WriteLine("=== Practice Result ===");
        Console.WriteLine(StringHelpers.LabelWithColon("Topic", topic));
        Console.WriteLine(StringHelpers.LabelWithColon("Questions", questions));
        Console.WriteLine(StringHelpers.LabelWithColon("Correct", correct));
        Console.WriteLine(StringHelpers.LabelWithColon("Percentage", $"{percentage}%"));
        Console.WriteLine(StringHelpers.LabelWithColon("Time Spent", $"{timeSpent} minutes"));
        Console.WriteLine(StringHelpers.LabelWithColon("Grade", grade));
        Console.WriteLine(StringHelpers.LabelWithColon("Passed", passed));
        Console.WriteLine(StringHelpers.LabelWithColon("Difficulty", difficulty));
    }
}