namespace CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise04;
public static class MainClass
{
    public static bool MeetsMinimumOrder(
    int itemPrice,
    int quantity,
    int shippingCost,
    int minimumOrder)
    {
        int orderCost = itemPrice * quantity + shippingCost;
        return orderCost >= minimumOrder;
    }
}