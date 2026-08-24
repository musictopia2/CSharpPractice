namespace CSharpPracticeLibrary.Section03Operators.Lesson06OrderOfOperations.Exercise05;
public static class MainClass
{
    public static int CalculateFlooringNeeded(
    int mainLength,
    int mainWidth,
    int extraLength,
    int extraWidth)
    {
        int mainArea = mainLength * mainWidth;
        int extraArea = extraLength * extraWidth;
        int totalArea = mainArea + extraArea;
        return totalArea + 10; //10 for waste;
    }
}