namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson07EscapeSequences.Exercise02;
public static class MainClass
{
    public static void PrintSaveReport()
    {
        Console.WriteLine($"Player:{ss1.VBTab}Alex");
        Console.WriteLine(@"Save Location: D:\Games\Profiles\Alex");
        Console.WriteLine($"Message: {StringHelpers.SurroundWithQuotes("Save completed.")}");
    }
}