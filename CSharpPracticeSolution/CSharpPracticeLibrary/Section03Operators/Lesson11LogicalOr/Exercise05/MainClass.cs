namespace CSharpPracticeLibrary.Section03Operators.Lesson11LogicalOr.Exercise05;
public static class MainClass
{
    public static bool ShouldPrioritizeOrder(
    int daysWaiting,
    bool isPriorityCustomer)
    {
        return daysWaiting >= 5 || isPriorityCustomer;
    }
}