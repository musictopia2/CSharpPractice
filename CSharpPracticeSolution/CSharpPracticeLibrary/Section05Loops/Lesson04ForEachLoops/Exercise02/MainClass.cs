namespace CSharpPracticeLibrary.Section05Loops.Lesson04ForEachLoops.Exercise02;
public static class MainClass
{
    public static int CountCompletedInspections(bool[] inspections)
    {
        int count = 0;
        foreach (var item in inspections)
        {
            if (item == true)
            {
                count++;
            }    
        }
        return count;
    }
}