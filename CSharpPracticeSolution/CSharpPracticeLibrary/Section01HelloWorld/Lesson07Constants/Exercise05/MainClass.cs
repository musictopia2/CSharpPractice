namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise05;
public static class MainClass
{
    public const string EventName = "Summer Coding Day";
    public const int MaximumAttendees = 75;
    public const double RegistrationFee = 12.5;
    public static string GetEventName()
    {
        return EventName;
    }
    public static int GetMaximumAttendees()
    {
        return MaximumAttendees;
    }
    public static double GetRegistrationFee()
    {
        return RegistrationFee;
    }
}