namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson07EscapeSequences.Exercise04;
public static class MainClass
{
    public static void PrintBuildSummary(string projectName, int warningCount)
    {
        Console.WriteLine(StringHelpers.LabelWithTab("Project:", projectName));
        Console.WriteLine(StringHelpers.LabelWithTab("Warnings:", warningCount.ToString()));
        Console.WriteLine(@$"Output: C:\Builds\{projectName}");
        Console.WriteLine(StringHelpers.LabelWithQuotes("Message: ", "Build review required."));
    }
}