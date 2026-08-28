namespace CSharpPracticeLibrary.Section03Operators.Lesson12LogicalNot.Exercise05;
public static class MainClass
{
    public static bool CanProcessOrder(
    bool paymentFailed,
    bool addressMissing,
    bool itemAvailable)
    {
        return !paymentFailed && !addressMissing && itemAvailable;
    }
}