namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson04LogicalPatterns.Exercise01;
public static class MainClass
{
    public static string GetHandlingCategory(int handlingCode)
    {
        if (handlingCode is 2 or 3)
        {
            return "Special";
        }
        if (handlingCode is >= 4 and <= 8)
        {
            return "Standard";
        }
        if (handlingCode is <= 0)
        {
            return "Invalid";
        }
        if (handlingCode is >= 9 and <= 20)
        {
            return "Bulk";
        }
        return "Oversized";
    }
}