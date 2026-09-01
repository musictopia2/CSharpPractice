namespace CSharpPracticeLibrary.Section05Loops.Lesson04ForEachLoops.Exercise03;
public static class MainClass
{
    public static int CalculateTotalPackages(int[] dailyPackages)
    {
        int count = 0;
        foreach (var item in dailyPackages)
        {
            count += item;
        }
        return count;
    }
}