namespace CSharpPracticeTests.Section03Operators.Lesson02Subtraction;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Fact]
    public void CalculateRemainingTickets_WhenSomeTicketsAreSold_ReturnsRemainingTickets()
    {
        int result = CSharpPracticeLibrary.Section03Operators.Lesson02Subtraction.Exercise01.MainClass
            .CalculateRemainingTickets(50, 12);

        Assert.Equal(38, result);
    }

    [Fact]
    public void CalculateRemainingTickets_WhenAllTicketsAreSold_ReturnsZero()
    {
        int result = CSharpPracticeLibrary.Section03Operators.Lesson02Subtraction.Exercise01.MainClass
            .CalculateRemainingTickets(25, 25);

        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateRemainingTickets_WhenMoreTicketsAreSoldThanAvailable_ReturnsNegativeNumber()
    {
        int result = CSharpPracticeLibrary.Section03Operators.Lesson02Subtraction.Exercise01.MainClass
            .CalculateRemainingTickets(10, 14);

        Assert.Equal(-4, result);
    }

    [Fact]
    public void CalculateRemainingTickets_WhenNoTicketsAreSold_ReturnsOriginalAmount()
    {
        int result = CSharpPracticeLibrary.Section03Operators.Lesson02Subtraction.Exercise01.MainClass
            .CalculateRemainingTickets(73, 0);

        Assert.Equal(73, result);
    }

    [Fact]
    public void CalculateRemainingTickets_WithDifferentValues_ReturnsCorrectDifference()
    {
        int result = CSharpPracticeLibrary.Section03Operators.Lesson02Subtraction.Exercise01.MainClass
            .CalculateRemainingTickets(120, 47);

        Assert.Equal(73, result);
    }

    [Theory]
    [InlineData(100, 25, 75)]
    [InlineData(40, 40, 0)]
    [InlineData(15, 30, -15)]
    [InlineData(85, 0, 85)]
    [InlineData(200, 73, 127)]
    public void CalculateScoreLoss_ReturnsCorrectScore(
        int startingScore,
        int pointsLost,
        int expected)
    {
        int actual = CSharpPracticeLibrary.Section03Operators.Lesson02Subtraction.Exercise02.MainClass
            .CalculateScoreLoss(startingScore, pointsLost);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(72, 58, 14)]
    [InlineData(40, 40, 0)]
    [InlineData(25, 32, -7)]
    [InlineData(-5, -12, 7)]
    [InlineData(-10, 5, -15)]
    public void CalculateTemperatureDrop_ReturnsCorrectDifference(
        int startingTemperature,
        int endingTemperature,
        int expected)
    {
        int actual = CSharpPracticeLibrary.Section03Operators.Lesson02Subtraction.Exercise03.MainClass
            .CalculateTemperatureDrop(startingTemperature, endingTemperature);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("Batteries", 50, 18, "Item: Batteries | Remaining: 32")]
    [InlineData("Markers", 20, 20, "Item: Markers | Remaining: 0")]
    [InlineData("Bolts", 10, 14, "Item: Bolts | Remaining: -4")]
    [InlineData("Cables", 75, 0, "Item: Cables | Remaining: 75")]
    public void CreateInventoryReport_ReturnsCorrectReport(
        string itemName,
        int startingQuantity,
        int quantityUsed,
        string expected)
    {
        string actual = CSharpPracticeLibrary.Section03Operators.Lesson02Subtraction.Exercise04.MainClass
            .CreateInventoryReport(itemName, startingQuantity, quantityUsed);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("Storage A", 50, 15, "Storage A has 35 units remaining.")]
    [InlineData("Supply Crate", 20, 20, "Supply Crate has 0 units remaining.")]
    [InlineData("Emergency Stock", 10, 13, "Emergency Stock has -3 units remaining.")]
    [InlineData("Warehouse Bin", 75, 0, "Warehouse Bin has 75 units remaining.")]
    [InlineData("Parts Shelf", 120, 47, "Parts Shelf has 73 units remaining.")]
    public void GetContainerStatus_ReturnsCorrectStatus(
        string containerName,
        int originalAmount,
        int amountRemoved,
        string expected)
    {
        string actual = CSharpPracticeLibrary.Section03Operators.Lesson02Subtraction.Exercise05.MainClass
            .GetContainerStatus(containerName, originalAmount, amountRemoved);

        Assert.Equal(expected, actual);
    }
}