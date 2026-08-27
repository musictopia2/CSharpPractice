namespace CSharpPracticeLibrary.Section03Operators.Lesson08IncrementAndDecrement.Exercise04;
public static class MainClass
{
    public static int CalculateNextLevelPoints(
    int currentLevel,
    int pointsPerLevel)
    {
        return ++currentLevel * pointsPerLevel;
        //currentLevel++;
        //return currentLevel * pointsPerLevel;
    }
}