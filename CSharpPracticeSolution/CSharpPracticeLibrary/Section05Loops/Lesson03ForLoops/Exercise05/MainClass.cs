namespace CSharpPracticeLibrary.Section05Loops.Lesson03ForLoops.Exercise05;
public static class MainClass
{
    public static int CountMaintenanceCheckpoints(
    int totalCycles,
    int checkpointInterval)
    {
        int leftOvers;
        int output = 0;
        totalCycles.Times(x =>
        {
            leftOvers = x.Remainder(checkpointInterval);
            if (leftOvers == 0)
            {
                output++;
            }
        });
        return output;
    }
}