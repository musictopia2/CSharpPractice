namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise01;
public static class MainClass
{
    public static void PrintCharacterProfile(
    string name,
    int level,
    double accuracy,
    decimal gold,
    char rank,
    bool isActive,
    float speed)
    {
        Console.WriteLine("=== Character Profile ===");
        Console.WriteLine(StringHelpers.LabelWithColon("Name", name));
        Console.WriteLine(StringHelpers.LabelWithColon("Level", level));
        Console.WriteLine(StringHelpers.LabelWithColon("Rank", rank));
        Console.WriteLine(StringHelpers.LabelWithColon("Accuracy", accuracy));
        Console.WriteLine(StringHelpers.LabelWithColon("Gold", gold));
        Console.WriteLine(StringHelpers.LabelWithColon("Speed", speed));
        Console.WriteLine(StringHelpers.LabelWithColon("Active", isActive));
        Console.WriteLine(StringHelpers.LabelWithColon("Save Path", $@"C:\Game\Saves\{name}"));
    }
}