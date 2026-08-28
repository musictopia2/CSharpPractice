namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson04LogicalPatterns.Exercise03;
public static class MainClass
{
    public static string GetMachineStatus(int statusCode)
    {
        if (statusCode is 1 or 2 or 3)
        {
            return "Starting";
        }
        if (statusCode is >= 10 and <= 20 and not 15)
        {
            return "Running";
        }
        if (statusCode is 15)
        {
            return "Maintenance";
        }
        if (statusCode is <= 0)
        {
            return "Invalid";
        }
        return "Unknown";
    }
}