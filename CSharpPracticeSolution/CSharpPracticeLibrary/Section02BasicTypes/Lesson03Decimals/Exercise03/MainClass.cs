namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson03Decimals.Exercise03;
public static class MainClass
{
    public static decimal CalculateOrderCost(decimal itemPrice, decimal quantity)
    {
        decimal output = decimal.Multiply(itemPrice, quantity);
        return output;
    }
}