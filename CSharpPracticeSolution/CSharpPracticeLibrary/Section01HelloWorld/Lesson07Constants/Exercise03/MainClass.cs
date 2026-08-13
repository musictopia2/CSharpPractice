namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise03;

public static class MainClass
{
    public const string StoreName = "Corner Market";
    public const int MaximumItems = 50;
    public const double SalesTaxRate = 0.08;
    public static string GetStoreName()
    {
        return StoreName;
    }
    public static int GetMaximumItems()
    {
        return MaximumItems;
    }
    public static double GetSalesTaxRate()
    {
        return SalesTaxRate;
    }
}