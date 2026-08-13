namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise02;
public static class MainClass
{
    public const int MatchesPerDay = 6;
    public const int DaysPerWeek = 7;
    public static int GetMatchesPerDay()
    {
        return MatchesPerDay;
    }
    public static int GetMaximumWeeklyMatches()
    {
        return DaysPerWeek * MatchesPerDay;
    }
}