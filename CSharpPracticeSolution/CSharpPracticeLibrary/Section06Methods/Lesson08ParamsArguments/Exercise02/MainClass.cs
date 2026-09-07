namespace CSharpPracticeLibrary.Section06Methods.Lesson08ParamsArguments.Exercise02;
public static class MainClass
{
    public static decimal CalculateSupplyCost(
    decimal shippingFee,
    params List<decimal> itemPrices)
    {
        return itemPrices.Sum() + shippingFee;
    }
}