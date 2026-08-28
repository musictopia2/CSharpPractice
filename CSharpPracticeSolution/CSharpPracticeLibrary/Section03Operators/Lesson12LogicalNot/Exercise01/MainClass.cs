namespace CSharpPracticeLibrary.Section03Operators.Lesson12LogicalNot.Exercise01;
public static class MainClass
{
    public static bool IsReady(bool isBroken, bool isMissing)
    {
        return !isBroken && !isMissing; //just so i can see how that works.
    }
}