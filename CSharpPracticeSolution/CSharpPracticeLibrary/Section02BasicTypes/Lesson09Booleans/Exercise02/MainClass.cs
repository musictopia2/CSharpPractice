namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise02;
public static class MainClass
{
    public static bool ShouldShowNotification(bool hasSystemWarning, bool hasUnreadMessage)
    {
        if (hasSystemWarning || hasUnreadMessage)
        {
            return true;
        }
        return false;
    }
}