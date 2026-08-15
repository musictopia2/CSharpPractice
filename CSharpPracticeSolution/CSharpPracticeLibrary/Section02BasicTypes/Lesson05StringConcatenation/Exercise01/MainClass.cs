namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson05StringConcatenation.Exercise01;
public static class MainClass
{
    public static void PrintPlayerSummary(string playerName, int level)
    {
        Console.WriteLine("Player:" + " " + playerName);
        Console.WriteLine("Level:" + " " + level);
        string details = playerName + " has reached level " + level + ".";
        Console.WriteLine(details);
    }
}