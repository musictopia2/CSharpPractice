namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson04LogicalPatterns.Exercise02;
public static class MainClass
{
    public static string GetAccessLevel(int code)
    {
        if (code is 1 or 5)
        {
            return "Guest";
        }
        if (code is >= 10 and <= 15)
        {
            return "Standard";
        }
        if (code is <= 0)
        {
            return "Invalid";
        }
        return "Restricted";
    }
}