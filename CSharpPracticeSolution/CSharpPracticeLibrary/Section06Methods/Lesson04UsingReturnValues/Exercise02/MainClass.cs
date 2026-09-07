namespace CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise02;
public static class MainClass
{
    public static int GetDailyProduction(int machines, int unitsPerMachine)
    {
        return machines * unitsPerMachine;
    }
    public static int GetWeeklyProduction(
        int machines,
        int unitsPerMachine,
        int workingDays)
    {
        int firsts = GetDailyProduction(machines, unitsPerMachine);
        return firsts * workingDays;
    }
}