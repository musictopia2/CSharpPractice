namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson06VerbatimStrings.Exercise05;
public static class MainClass
{
    public static void PrintDeploymentSettings(string applicationName)
    {
        string deploymentDirectory = @"C:\CompanyTools\Deployment\Config";
        string otherInfo = $"""
            Application: "{applicationName}"
            """;
        Console.WriteLine(otherInfo);
        Console.WriteLine($"Configuration: {deploymentDirectory}");
    }
}