namespace CSharpPracticeLibrary.Section03Operators.Lesson10LogicalAnd.Exercise04;
public static class MainClass
{
    public static bool CanShipOrder(
    int itemsInStock,
    int itemsRequested,
    bool paymentApproved)
    {
        return itemsInStock >= itemsRequested && paymentApproved;
    }
}