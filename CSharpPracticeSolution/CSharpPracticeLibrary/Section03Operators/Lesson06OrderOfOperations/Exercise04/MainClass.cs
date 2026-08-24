namespace CSharpPracticeLibrary.Section03Operators.Lesson06OrderOfOperations.Exercise04;
public static class MainClass
{
    public static int CalculateScore(
    int regularObjectives,
    int bonusObjectives,
    int pointsPerObjective,
    int penalty)
    {
        int totalObjectives = regularObjectives + bonusObjectives;
        int earnedPoints = totalObjectives * pointsPerObjective;
        return earnedPoints - penalty;
    }
}