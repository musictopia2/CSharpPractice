namespace CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise04;
public static class MainClass
{
    public static decimal GetMerchandiseCost(
    int quantity,
    decimal pricePerItem)
    {
        return quantity * pricePerItem;
    }
    public static decimal GetOrderTotal(
        int quantity,
        decimal pricePerItem,
        decimal deliveryCharge)
    {
        decimal cost = GetMerchandiseCost(quantity, pricePerItem);
        return cost + deliveryCharge;
    }
}