namespace CSharpPracticeLibrary.Section05Loops.Lesson06NestedLoops.Exercise05;
public static class MainClass
{
    public static int CountMatchingAssignments(
    List<int> employeeNumbers,
    List<int> stationNumbers)
    {
        int count = 0;
        foreach (var employee in employeeNumbers)
        {
            foreach (var station in stationNumbers)
            {
                if (employee == station)
                {
                    count++;
                }
            }
        }
        return count;
    }

}