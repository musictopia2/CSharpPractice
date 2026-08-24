namespace CSharpPracticeLibrary.Section03Operators.Lesson02Subtraction.Exercise05;
public static class MainClass
{
    public static string GetContainerStatus(
    string containerName,
    int originalAmount,
    int amountRemoved)
    {
        int totalLeft = originalAmount - amountRemoved;
        return $"{containerName} has {totalLeft} units remaining.";
    }
}