namespace CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise05;
public static class MainClass
{
    public static void StartMachine(string machineName, bool safetyCheckPassed)
    {
        Console.WriteLine($"Starting: {machineName}");
        if (safetyCheckPassed)
        {
            PrintStartedMessage();
        }
        else
        {
            PrintBlockedMessage();
        }   
    }
    private static void PrintStartedMessage()
    {
        Console.WriteLine("Machine started.");
    }
    private static void PrintBlockedMessage()
    {
        Console.WriteLine("Startup blocked.");
    }
}