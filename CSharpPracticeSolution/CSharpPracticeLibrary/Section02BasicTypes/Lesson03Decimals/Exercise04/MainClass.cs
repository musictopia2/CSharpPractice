namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson03Decimals.Exercise04;
public static class MainClass
{
    public static decimal CalculatePricePerTicket(decimal totalCost, decimal ticketCount)
    {
        decimal output = decimal.Divide(totalCost, ticketCount);
        return output;
    }
}