namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson05StringConcatenation.Exercise02;
public static class MainClass
{
    public static void PrintGameStatus(string gameName, int players)
    {
        Console.WriteLine("Game: " + gameName);
        Console.WriteLine("Players: " + players);
        Console.WriteLine(gameName + " currently has " + players + " players online.");
    }
}