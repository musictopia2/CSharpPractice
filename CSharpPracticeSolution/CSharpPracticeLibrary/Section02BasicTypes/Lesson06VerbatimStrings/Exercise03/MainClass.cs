namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson06VerbatimStrings.Exercise03;
public static class MainClass
{
    public static void PrintFileInstructions()
    {
        string instructions = @"Open the ""Exports"" folder and select ""customers.csv"".";
        Console.WriteLine(instructions);
    }
}