namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson07EscapeSequences.Exercise05;
public static class MainClass
{
    public static void PrintDeploymentReceipt(string applicationName, string version)
    {
        Console.WriteLine(StringHelpers.LabelWithTab("Application:", applicationName));
        Console.WriteLine(StringHelpers.LabelWithTab("Version:", version));
        Console.WriteLine(@$"Install Directory: C:\Applications\{applicationName}");
        Console.WriteLine(StringHelpers.LabelWithQuotes("Status: ", "Deployment complete."));
    }
}