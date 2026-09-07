namespace CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise04;
public static class MainClass
{
    public static decimal CalculateServiceTotal(decimal hourlyRate, int hoursWorked, decimal additionalFee = 0m)
    {
        decimal regularCost = hourlyRate * hoursWorked;
        decimal totalCost = regularCost + additionalFee;
        return totalCost;
    }
}