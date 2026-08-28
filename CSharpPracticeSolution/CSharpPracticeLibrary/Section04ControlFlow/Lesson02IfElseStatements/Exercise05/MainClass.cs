namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson02IfElseStatements.Exercise05;
public static class MainClass
{
    public static void PrintLateFeeStatus(
    int daysKept,
    int allowedDays,
    bool hasExtension)
    {
        bool isLate;
        isLate = hasExtension == false && daysKept > allowedDays;
        if (isLate)
        {
            Console.WriteLine("Late Fee Required");
        }
        else
        {
            Console.WriteLine("No Late Fee");
        }
    }
}