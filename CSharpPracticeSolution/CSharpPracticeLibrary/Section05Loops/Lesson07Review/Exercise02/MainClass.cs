namespace CSharpPracticeLibrary.Section05Loops.Lesson07Review.Exercise02;
public static class MainClass
{
    public static int CountProductionRuns(
    int startingUnits,
    int unitsPerRun,
    int targetUnits)
    {
        int upTo = startingUnits;
        int runsCompleted = 0;
        do
        {
            if (upTo >= targetUnits)
            {
                return runsCompleted;
            }
            upTo += unitsPerRun;
            runsCompleted++;
        } while (true);
    }
}