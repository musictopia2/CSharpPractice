namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson01Integers.Exercise04;
public static class MainClass
{
    public static int GetScoreDifference(
    int startingScore,
    int pointsEarned,
    int pointsLost)
    {
        return startingScore + pointsEarned - pointsLost;
    }
}