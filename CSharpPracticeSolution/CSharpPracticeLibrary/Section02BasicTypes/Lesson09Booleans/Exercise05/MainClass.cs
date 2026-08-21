namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise05;
public static class MainClass
{
    public static bool ShouldSendReleaseNotification(
    bool releaseReady,
    bool isSubscribed,
    bool isCritical,
    bool notificationsMuted)
    {
        if (notificationsMuted)
        {
            return false;
        }
        if (releaseReady == false)
        {
            return false;
        }
        if (isCritical)
        {
            return true;
        }
        return isSubscribed;
    }
}