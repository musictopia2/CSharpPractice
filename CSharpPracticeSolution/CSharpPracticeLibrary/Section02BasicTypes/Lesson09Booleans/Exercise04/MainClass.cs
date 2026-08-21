namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise04;
public static class MainClass
{
    public static bool CanDeploy(bool passedTesting, bool isApproved, bool isBlocked)
    {
        return passedTesting && isApproved && isBlocked == false;
    }
}