namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise01;
public static class MainClass
{
    public const int MaximumUsers = 25;
    public const int HoursPerWeek = 168;
    public const string ApplicationTitle = "Practice Tracker";
    public static int GetMaximumUsers()
    {
        return MaximumUsers;
    }
    public static int GetHoursPerWeek()
    {
        return HoursPerWeek;
    }
    public static string GetApplicationTitle()
    {
        return ApplicationTitle;
    }
}