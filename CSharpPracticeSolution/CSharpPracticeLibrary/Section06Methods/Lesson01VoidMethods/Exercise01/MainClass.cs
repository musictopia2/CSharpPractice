namespace CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise01;
public static class MainClass
{
    public static void DisplayNotice()
    {
        PrintNotice();
    }
    private static void PrintNotice()
    {
        Console.WriteLine("System is ready.");
    }
}