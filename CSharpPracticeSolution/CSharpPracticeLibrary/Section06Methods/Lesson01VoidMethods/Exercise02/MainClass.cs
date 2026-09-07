namespace CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise02;
public static class MainClass
{
    public static void ShowMaintenanceMessage()
    {
        PrintMaintenanceMessage();
    }
    private static void PrintMaintenanceMessage()
    {
        Console.WriteLine("Maintenance check started.");
    }
}