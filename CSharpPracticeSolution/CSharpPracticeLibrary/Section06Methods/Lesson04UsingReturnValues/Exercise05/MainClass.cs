namespace CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise05;
public static class MainClass
{
    public static decimal CalculateShippingCost(
    int packageCount,
    decimal pricePerPackage)
    {
        return packageCount * pricePerPackage;
    }

    public static decimal CalculateInvoiceTotal(
        int packageCount,
        decimal pricePerPackage,
        decimal serviceFee)
    {
        decimal shippingCost = CalculateShippingCost(packageCount, pricePerPackage);
        return shippingCost + serviceFee;
    }
}