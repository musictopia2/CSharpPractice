namespace CSharpPracticeLibrary.Section06Methods.Lesson06NamedArguments.Exercise04;
public static class MainClass
{
    public static int CalculateSupplyCost(
    int quantity,
    int costPerItem,
    int deliveryFee)
    {
        int subs = quantity * costPerItem;
        return subs + deliveryFee;
    }
    public static int CalculateRushSupplyCost(
    int quantity,
    int costPerItem,
    int deliveryFee,
    int rushFee)
    {
        int subs = CalculateSupplyCost(deliveryFee: deliveryFee, quantity: quantity, costPerItem: costPerItem);
        return subs + rushFee;
    }
}