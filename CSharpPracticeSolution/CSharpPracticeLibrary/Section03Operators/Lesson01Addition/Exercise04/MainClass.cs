namespace CSharpPracticeLibrary.Section03Operators.Lesson01Addition.Exercise04;
public static class MainClass
{
    public static string CreateScoreSummary(string playerName, int firstRoundScore, int secondRoundScore)
    {
        int totalScore = firstRoundScore + secondRoundScore;
        return $"Player: {playerName} | Total Score: {totalScore}";
    }
}