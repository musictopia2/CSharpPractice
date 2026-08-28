namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson07TernaryOperator.Exercise04;

public static class MainClass
{
    public static int CalculateFinalCost(
    int itemCount,
    int pricePerItem,
    bool isMember)
    {
        int originalCost = itemCount * pricePerItem;
        int discount = isMember ? 10 : 0;
        return originalCost - discount;
    }
}