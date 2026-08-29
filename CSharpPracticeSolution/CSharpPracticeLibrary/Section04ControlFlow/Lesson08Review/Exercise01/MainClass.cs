namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson08Review.Exercise01;
public static class MainClass
{
    public static string GetShippingPriority(int itemCount, bool isExpress)
    {
        if (itemCount is < 1)
        {
            return "Invalid Order";
        }
        if (isExpress)
        {
            return "Express";
        }
        if (itemCount is >= 50)
        {
            return "Bulk";
        }
        return "Standard";
    }
}