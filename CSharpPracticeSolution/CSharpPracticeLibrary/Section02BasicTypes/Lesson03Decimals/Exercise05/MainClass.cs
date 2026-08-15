namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson03Decimals.Exercise05;
public static class MainClass
{
    public static decimal CalculateInvoiceTotal(
    decimal itemPrice,
    decimal quantity,
    decimal shippingCost)
    {
        decimal firsts = decimal.Multiply(itemPrice, quantity);
        decimal output = decimal.Add(firsts, shippingCost);
        return output;
    }
}