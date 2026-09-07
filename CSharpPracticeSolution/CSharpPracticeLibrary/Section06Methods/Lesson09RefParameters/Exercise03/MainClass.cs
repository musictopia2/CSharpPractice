namespace CSharpPracticeLibrary.Section06Methods.Lesson09RefParameters.Exercise03;
public static class MainClass
{
    public static void AdjustBalance(ref int balance, int adjustment)
    {
        balance += adjustment;
    }
}