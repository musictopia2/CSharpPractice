namespace CSharpPracticeLibrary.Section03Operators.Lesson13Review.Exercise03;
public static class MainClass
{
    public static bool IsScoreAccepted(
    int score,
    int minimumScore,
    int maximumScore,
    bool isDisqualified)
    {
        bool isAcceptable = score >= minimumScore && score <= maximumScore;
        return isAcceptable && !isDisqualified;
    }
}