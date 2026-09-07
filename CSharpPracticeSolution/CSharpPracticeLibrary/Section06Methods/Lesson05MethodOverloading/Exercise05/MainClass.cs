namespace CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise05;
public static class MainClass
{
    public static decimal CalculateServiceCost(int hoursWorked, decimal hourlyRate)
    {
        return hoursWorked * hourlyRate;
    }
    public static decimal CalculateServiceCost(int hoursWorked, decimal hourlyRate, decimal partsCost)
    {
        return CalculateServiceCost(hoursWorked, hourlyRate) + partsCost;
    }
}