namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson07TernaryOperator.Exercise03;
public static class MainClass
{
    public static int GetBonusPoints(int score, int requiredScore)
    {
        return score >= requiredScore ? 100 : 0;
    }
}