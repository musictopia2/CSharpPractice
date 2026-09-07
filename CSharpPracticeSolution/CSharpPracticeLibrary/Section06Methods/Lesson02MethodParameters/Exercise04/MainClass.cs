namespace CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise04;
public static class MainClass
{
    public static void Main()
    {
        DisplayInspectionResult("Press 4", 0);
    }
    public static void DisplayInspectionResult(string machineName, int defectsFound)
    {
        string status;
        if (defectsFound == 0)
        {
            status = "Passed";
        }
        else
        {
            status = "Failed";
        }
        Console.WriteLine($"{machineName}: Inspection {status}");
    }
}