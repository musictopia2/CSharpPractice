namespace CSharpPracticeLibrary.Section03Operators.Lesson13Review.Exercise01;
public static class MainClass
{
    public static bool HasEnoughSupply(
    int startingSupply,
    int deliveredSupply,
    int usedSupply,
    int minimumRequired)
    {
        int totals = startingSupply + deliveredSupply - usedSupply;
        return totals >= minimumRequired;
    }
}