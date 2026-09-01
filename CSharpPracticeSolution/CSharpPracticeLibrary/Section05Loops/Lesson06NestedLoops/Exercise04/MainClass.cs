namespace CSharpPracticeLibrary.Section05Loops.Lesson06NestedLoops.Exercise04;
public static class MainClass
{
    public static int CountRequiredMaintenance(
    List<int> machines,
    List<int> maintenanceDays)
    {
        int output = 0;
        foreach (var machine in machines)
        {
            foreach (var day in maintenanceDays)
            {
                int leftOvers = day.Remainder(3);
                if (leftOvers == 0)
                {
                    output++;
                }
            }
        }
        return output;
    }
}
/*
A factory has several machines and several scheduled maintenance days. However, maintenance is only required on days that are evenly divisible by 3.

Use nested foreach loops:

The outer loop processes each machine.
The inner loop processes every maintenance day for that machine.
For each machine/day combination, determine whether the maintenance day is evenly divisible by 3.
If it is, count that as one required maintenance task.
If it is not, do not count it.
Return the total number of required maintenance tasks.
*/