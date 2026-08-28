namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson04LogicalPatterns.Exercise05;
public static class MainClass
{
    public static string GetShippingAction(int zone)
    {
        if (zone is 1 or 3 or 5)
        {
            return "Local";
        }
        if (zone is >= 10 and <= 20 and not 15)
        {
            return "Regional";
        }
        if (zone is 15)
        {
            return "Manual Review";
        }
        if (zone is not > 0)
        {
            return "Invalid";
        }
        return "Long Distance";
    }
}