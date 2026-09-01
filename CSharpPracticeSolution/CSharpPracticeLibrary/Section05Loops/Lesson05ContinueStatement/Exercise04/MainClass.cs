namespace CSharpPracticeLibrary.Section05Loops.Lesson05ContinueStatement.Exercise04;
public static class MainClass
{
    public static int CalculateQualifyingScoreTotal(List<int> scores)
    {
        int totalScore = 0;
        foreach (var item in scores)
        {
            if (item < 50)
            {
                continue;
            }
            totalScore += item;
        }
        return totalScore;
    }
}