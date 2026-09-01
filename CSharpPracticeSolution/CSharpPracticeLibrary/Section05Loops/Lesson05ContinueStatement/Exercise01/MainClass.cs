namespace CSharpPracticeLibrary.Section05Loops.Lesson05ContinueStatement.Exercise01;
public static class MainClass
{
    public static void DisplayInspectionDays(List<int> inspectionDays)
    {
        foreach (var item in inspectionDays)
        {
            if (item.Remainder(4) == 0)
            {
                continue;
            }
            Console.WriteLine(item);
        }
    }
}