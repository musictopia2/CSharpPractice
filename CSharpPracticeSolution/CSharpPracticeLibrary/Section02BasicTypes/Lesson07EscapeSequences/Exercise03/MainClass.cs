namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson07EscapeSequences.Exercise03;
public static class MainClass
{
    public static void PrintConnectionDetails(string serverName)
    {
        Console.WriteLine($"Server:{ss1.VBTab}{serverName}");
        Console.WriteLine(@$"Config: C:\Network\Servers\{serverName}");
        Console.WriteLine(StringHelpers.LabelWithQuotes("Message: ", "Connection ready."));
    }
}