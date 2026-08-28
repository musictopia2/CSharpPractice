namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson02IfElseStatements.Exercise01;
public static class MainClass
{
    public static void PrintCapacityStatus(int currentAmount, int requiredAmount)
    {
        if (currentAmount >= requiredAmount)
        {
            Console.WriteLine("Ready");
        }
        else
        {
            Console.WriteLine("Not Ready");
        }
    }
}