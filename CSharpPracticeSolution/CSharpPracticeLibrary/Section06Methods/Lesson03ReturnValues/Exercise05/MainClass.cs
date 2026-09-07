namespace CSharpPracticeLibrary.Section06Methods.Lesson03ReturnValues.Exercise05;
public static class MainClass
{
    public static int CalculatePassedInspections(
    int totalInspected,
    int failedInspections)
    {
        return totalInspected - failedInspections;
    }
}