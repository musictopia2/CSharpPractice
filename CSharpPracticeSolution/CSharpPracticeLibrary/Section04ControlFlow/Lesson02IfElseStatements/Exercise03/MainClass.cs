namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson02IfElseStatements.Exercise03;
public static class MainClass
{
    public static void PrintPackingStatus(int itemCount, int itemsPerCase)
    {
        int leftOvers = itemCount.Remainder(itemsPerCase);
        if (leftOvers == 0)
        {
            Console.WriteLine("Full Cases");
        }
        else
        {
            Console.WriteLine("Items Left Over");
        }
    }
}