namespace CSharpPracticeLibrary.Section05Loops.Lesson04ForEachLoops.Exercise04;
public static class MainClass
{
    public static int CountPriorityShipments(int[] packageCounts)
    {
        int count = 0;
        foreach (int i in packageCounts)
        {
            if (i >= 20)
            {
                count++;
            }
        }
        return count;
    }
}