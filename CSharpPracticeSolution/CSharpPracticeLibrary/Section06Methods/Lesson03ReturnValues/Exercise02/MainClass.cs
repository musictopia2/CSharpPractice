namespace CSharpPracticeLibrary.Section06Methods.Lesson03ReturnValues.Exercise02;
public static class MainClass
{
    public static int CalculateMilesRemaining(
    int totalMiles,
    int milesCompleted)
    {
        return totalMiles - milesCompleted;
    }
}