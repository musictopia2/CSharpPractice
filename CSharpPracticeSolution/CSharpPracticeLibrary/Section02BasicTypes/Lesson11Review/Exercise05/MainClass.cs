namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise05;
public static class MainClass
{
    public static void PrintGameSave(
    string playerName,
    int level,
    double completion,
    decimal gold,
    char difficulty,
    bool autoSave,
    float playTime)
    {
        Console.WriteLine("=== Game Save ===");
        string quoted = StringHelpers.SurroundWithQuotes(playerName);
        Console.WriteLine(StringHelpers.LabelWithColon("Player", quoted));
        Console.WriteLine(StringHelpers.LabelWithColon("Level", level));
        Console.WriteLine(StringHelpers.LabelWithColon("Completion", $"{completion}%"));
        Console.WriteLine(StringHelpers.LabelWithColon("Gold", $"${gold}"));
        Console.WriteLine(StringHelpers.LabelWithColon("Difficulty", difficulty));
        Console.WriteLine(StringHelpers.LabelWithColon("Auto Save", autoSave));
        Console.WriteLine(StringHelpers.LabelWithColon("Play Time", $"{playTime} hours"));
        Console.WriteLine("Save File:");
        Console.Write(ss1.VBTab);
        Console.WriteLine($@"C:\Game\Saves\{playerName}\Level{level}.sav");
    }
}