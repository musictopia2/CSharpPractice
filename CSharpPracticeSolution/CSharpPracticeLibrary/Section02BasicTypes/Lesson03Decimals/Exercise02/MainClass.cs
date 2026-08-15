namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson03Decimals.Exercise02;
public static class MainClass
{
    public static decimal CalculateRemainingBalance(decimal giftCardBalance, decimal purchaseAmount)
    {
        decimal output = decimal.Subtract(giftCardBalance, purchaseAmount);
        return output;
    }
}