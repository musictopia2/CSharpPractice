namespace CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise05;
public static class MainClass
{
    public static bool CanShipOrder(
    int unitsPerBox,
    int numberOfBoxes,
    int unitsRequested)
    {
        int totals = unitsPerBox * numberOfBoxes;
        return totals >= unitsRequested;
    }
}