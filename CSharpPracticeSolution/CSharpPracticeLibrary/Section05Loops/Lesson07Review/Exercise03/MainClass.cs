namespace CSharpPracticeLibrary.Section05Loops.Lesson07Review.Exercise03;
public static class MainClass
{
    public static int CountRequiredInspections(
    int numberOfMachines,
    int inspectionsPerMachine)
    {
        int count = 0;
        numberOfMachines.Times(x =>
        {
            count += inspectionsPerMachine;
        });
        return count;
    }
}