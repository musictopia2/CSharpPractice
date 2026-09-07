namespace CSharpPracticeLibrary.Section06Methods.Lesson03ReturnValues.Exercise04;
public static class MainClass
{
    public static decimal CalculateOrderTotal(
    int quantity,
    decimal pricePerItem)
    {
        decimal subs = quantity * pricePerItem;
        if (quantity < 20)
        {
            return subs;
        }
        decimal discount = subs * .1m;
        return subs - discount;
    }
}