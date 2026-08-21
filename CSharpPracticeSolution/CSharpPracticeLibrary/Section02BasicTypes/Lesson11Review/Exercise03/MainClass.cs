namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise03;
public static class MainClass
{
    public static void PrintDeploymentSummary(
    string application,
    int buildNumber,
    double testCoverage,
    decimal deploymentCost,
    char environment,
    bool successful,
    float duration)
    {
        Console.WriteLine(
            StringHelpers.LabelWithColon(
                "Deployment",
                application + " - Build " + buildNumber));

        Console.WriteLine(
            StringHelpers.LabelWithColon("Environment", environment));

        Console.WriteLine(
            StringHelpers.LabelWithColon("Test Coverage", $"{testCoverage}%"));

        Console.WriteLine(
            StringHelpers.LabelWithColon("Cost", $"${deploymentCost}"));

        Console.WriteLine(
            StringHelpers.LabelWithColon("Duration", $"{duration} minutes"));

        Console.WriteLine(
            StringHelpers.LabelWithColon("Successful", successful));

        string quoted = StringHelpers.SurroundWithQuotes(application);

        Console.WriteLine(
            StringHelpers.LabelWithColon(
                "Message",
                quoted + " deployment completed."));

        Console.WriteLine(
            StringHelpers.LabelWithColon(
                "Log File",
                @"C:\Deployments\" + application + @"\build-" + buildNumber + ".log"));
    }
}