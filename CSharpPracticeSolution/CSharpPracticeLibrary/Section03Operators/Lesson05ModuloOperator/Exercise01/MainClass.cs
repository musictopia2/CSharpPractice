namespace CSharpPracticeLibrary.Section03Operators.Lesson05ModuloOperator.Exercise01;
public static class MainClass
{
    public static int GetLeftover(int itemCount, int groupSize)
    {
        return itemCount.Remainder(groupSize);
    }
}