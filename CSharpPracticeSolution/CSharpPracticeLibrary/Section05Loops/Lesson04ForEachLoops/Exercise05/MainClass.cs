namespace CSharpPracticeLibrary.Section05Loops.Lesson04ForEachLoops.Exercise05;
public static class MainClass
{
    public static int CountFlaggedReadings(int[] readings)
    {
        int flagged = 0;
        foreach (var item in readings)
        {
            if (item is < 10 or > 90)
            {
                flagged++;
            }
        }
        return flagged;
    }
}