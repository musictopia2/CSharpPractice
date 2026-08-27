namespace CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise03;
public static class MainClass
{
    public static bool HasEnoughSpace(int availableSpace, int requiredSpace)
    {
        return availableSpace >= requiredSpace;
    }

    public static bool IsOverCapacity(int usedSpace, int capacity)
    {
        return usedSpace > capacity;
    }

    public static bool HasExactUsage(int usedSpace, int expectedUsage)
    {
        return usedSpace == expectedUsage;
    }

    public static bool IsBelowMinimum(int availableSpace, int minimumSpace)
    {
        return availableSpace < minimumSpace;
    }
}