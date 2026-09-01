namespace CSharpPracticeLibrary.Section05Loops.Lesson05ContinueStatement.Exercise02;
public static class MainClass
{
    public static void DisplayAvailableWorkstations(List<int> workstationNumbers)
    {
        foreach (var item in workstationNumbers)
        {
            if (item <= 0)
            {
                continue;
            }
            Console.WriteLine(item);
        }
    }
}