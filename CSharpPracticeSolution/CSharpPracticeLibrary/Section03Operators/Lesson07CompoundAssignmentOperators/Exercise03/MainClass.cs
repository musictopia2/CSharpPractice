namespace CSharpPracticeLibrary.Section03Operators.Lesson07CompoundAssignmentOperators.Exercise03;
public static class MainClass
{
    public static int CalculateProductionTime(
    int baseTime,
    int extraWork,
    int workerDivisor,
    int cleanupTime)
    {
        int output = baseTime;
        output += extraWork;
        output /= workerDivisor;
        output += cleanupTime;
        return output;
    }
}