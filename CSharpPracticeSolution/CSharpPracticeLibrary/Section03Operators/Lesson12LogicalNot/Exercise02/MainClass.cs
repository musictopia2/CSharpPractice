namespace CSharpPracticeLibrary.Section03Operators.Lesson12LogicalNot.Exercise02;
public static class MainClass
{
    public static bool CanStartDownload(bool isOffline)
    {
        return !isOffline;
    }
}