namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson02IfElseStatements.Exercise02;
public static class MainClass
{
    public static void PrintWeightStatus(int packageWeight, int maximumWeight)
    {
        if (packageWeight <= maximumWeight)
        {
            Console.WriteLine("Accepted");
        }
        else
        {
            Console.WriteLine("Too Heavy");
        }
    }
}