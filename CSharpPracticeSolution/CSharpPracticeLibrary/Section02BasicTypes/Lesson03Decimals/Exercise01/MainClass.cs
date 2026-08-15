namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson03Decimals.Exercise01;
public static class MainClass
{
    public static decimal CalculateBalance(decimal currentBalance, decimal depositAmount)
    {
        decimal output = decimal.Add(currentBalance, depositAmount);
        return output;
    }
}