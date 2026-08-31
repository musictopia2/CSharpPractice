namespace CSharpPracticeLibrary.Section05Loops.Lesson02DoWhileLoops.Exercise04;
public static class MainClass
{
    public static int CalculateProductionRuns(
    int currentUnits,
    int unitsPerRun,
    int targetUnits)
    {
        int upTo = currentUnits;
        int attempts = 0;
        do
        {
            upTo += unitsPerRun;
            attempts++;
            if (upTo >= targetUnits)
            {
                return attempts;
            }

        } while (true);
    }
}