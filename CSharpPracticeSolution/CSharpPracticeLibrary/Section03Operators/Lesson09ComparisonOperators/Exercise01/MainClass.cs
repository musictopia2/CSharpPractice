namespace CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise01;
public static class MainClass
{
    public static bool ScoresMatch(int firstScore, int secondScore)
    {
        return firstScore == secondScore;
    }

    public static bool ScoresDiffer(int firstScore, int secondScore)
    {
        return firstScore != secondScore;
    }

    public static bool FirstScoreIsHigher(int firstScore, int secondScore)
    {
        return firstScore > secondScore;
    }

    public static bool FirstScoreIsLower(int firstScore, int secondScore)
    {
        return firstScore < secondScore;
    }

    public static bool FirstScoreIsAtLeast(int firstScore, int secondScore)
    {
        return firstScore >= secondScore;
    }

    public static bool FirstScoreIsAtMost(int firstScore, int secondScore)
    {
        return firstScore <= secondScore;
    }
}