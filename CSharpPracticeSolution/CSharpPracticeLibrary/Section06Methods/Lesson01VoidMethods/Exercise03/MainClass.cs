namespace CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise03;
public static class MainClass
{
    public static void DisplayProductionStatus(int machineNumber)
    {
        Console.WriteLine($"Machine {machineNumber}");
        PrintReadyMessage();
    }
    private static void PrintReadyMessage()
    {
        Console.WriteLine("Ready for production.");
    }
}