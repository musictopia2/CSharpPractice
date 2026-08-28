namespace CSharpPracticeLibrary.Section03Operators.Lesson10LogicalAnd.Exercise05;
public static class MainClass
{
    public static bool CanRegisterForWorkshop(
    int currentAttendees,
    int maximumAttendees,
    bool prerequisiteCompleted)
    {
        return currentAttendees < maximumAttendees && prerequisiteCompleted;
    }
}