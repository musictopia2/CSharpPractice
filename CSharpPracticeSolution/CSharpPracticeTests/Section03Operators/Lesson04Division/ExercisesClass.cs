namespace CSharpPracticeTests.Section03Operators.Lesson04Division;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Theory]
    [InlineData(18.0, 4.0, 4.5)]
    [InlineData(20.0, 5.0, 4.0)]
    [InlineData(7.0, 2.0, 3.5)]
    [InlineData(15.0, 4.0, 3.75)]
    [InlineData(1.0, 8.0, 0.125)]
    public void Exercise01_CalculateAverageShare_ReturnsCorrectResult(
       double totalAmount,
       double numberOfShares,
       double expected)
    {
        double actual =
            CSharpPracticeLibrary.Section03Operators.Lesson04Division.Exercise01.MainClass
                .CalculateAverageShare(totalAmount, numberOfShares);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(25.0, 4.0, 6.25)]
    [InlineData(18.0, 3.0, 6.0)]
    [InlineData(10.0, 8.0, 1.25)]
    [InlineData(7.5, 3.0, 2.5)]
    [InlineData(1.0, 4.0, 0.25)]
    public void Exercise02_CalculateUnitPrice_ReturnsCorrectResult(
        double totalPrice,
        double quantity,
        double expected)
    {
        double actual =
            CSharpPracticeLibrary.Section03Operators.Lesson04Division.Exercise02.MainClass
                .CalculateUnitPrice(totalPrice, quantity);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(50.0, 4.0, 12.5)]
    [InlineData(60.0, 3.0, 20.0)]
    [InlineData(7.0, 2.0, 3.5)]
    [InlineData(-30.0, 4.0, -7.5)]
    [InlineData(30.0, -4.0, -7.5)]
    public void Exercise03_CalculateTimePerTask_ReturnsCorrectResult(
        double availableMinutes,
        double taskCount,
        double expected)
    {
        double actual =
            CSharpPracticeLibrary.Section03Operators.Lesson04Division.Exercise03.MainClass
                .CalculateTimePerTask(availableMinutes, taskCount);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5.0, 0.0)]
    [InlineData(-5.0, 0.0)]
    public void Exercise03_CalculateTimePerTask_DividingByZeroReturnsInfinity(
        double availableMinutes,
        double taskCount)
    {
        double actual =
            CSharpPracticeLibrary.Section03Operators.Lesson04Division.Exercise03.MainClass
                .CalculateTimePerTask(availableMinutes, taskCount);

        Assert.True(double.IsInfinity(actual));
    }
    [Theory]
    [InlineData(50.0, 8.0, 4.0, 10.5)]
    [InlineData(100.0, 25.0, 5.0, 15.0)]
    [InlineData(30.0, 5.0, 4.0, 6.25)]
    [InlineData(12.5, 2.5, 2.0, 5.0)]
    [InlineData(20.0, 30.0, 2.0, -5.0)]
    public void Exercise04_CalculateRemainingShare_ReturnsCorrectResult(
        double startingAmount,
        double amountUsed,
        double numberOfPeople,
        double expected)
    {
        double actual =
            CSharpPracticeLibrary.Section03Operators.Lesson04Division.Exercise04.MainClass
                .CalculateRemainingShare(startingAmount, amountUsed, numberOfPeople);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(135.0, 6.0, 22.5)]
    [InlineData(200.0, 8.0, 25.0)]
    [InlineData(75.0, 4.0, 18.75)]
    [InlineData(10.0, 3.0, 10.0 / 3.0)]
    [InlineData(0.0, 5.0, 0.0)]
    public void Exercise05_CalculateHourlyProduction_ReturnsCorrectResult(
        double totalProduced,
        double hoursWorked,
        double expected)
    {
        double actual =
            CSharpPracticeLibrary.Section03Operators.Lesson04Division.Exercise05.MainClass
                .CalculateHourlyProduction(totalProduced, hoursWorked);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(25.0, 0.0)]
    [InlineData(-25.0, 0.0)]
    public void Exercise05_CalculateHourlyProduction_DividingByZeroReturnsInfinity(
        double totalProduced,
        double hoursWorked)
    {
        double actual =
            CSharpPracticeLibrary.Section03Operators.Lesson04Division.Exercise05.MainClass
                .CalculateHourlyProduction(totalProduced, hoursWorked);

        Assert.True(double.IsInfinity(actual));
    }
}