namespace CSharpPracticeLibrary.Section03Operators.Lesson05ModuloOperator.Exercise04;
public static class MainClass
{
    public static int GetRemainingMinutes(int totalMinutes)
    {
        return totalMinutes.Remainder(60);
    }
}