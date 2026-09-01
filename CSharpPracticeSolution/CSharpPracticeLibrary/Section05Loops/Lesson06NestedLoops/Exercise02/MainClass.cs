namespace CSharpPracticeLibrary.Section05Loops.Lesson06NestedLoops.Exercise02;
public static class MainClass
{
    public static void DisplayInspectionPoints(List<int> machines, List<int> checkpoints)
    {
        foreach (var machine in machines)
        {
            foreach (var check in checkpoints)
            {
                Console.WriteLine($"Machine {machine} - Checkpoint {check}");
            }
        }
    }
}