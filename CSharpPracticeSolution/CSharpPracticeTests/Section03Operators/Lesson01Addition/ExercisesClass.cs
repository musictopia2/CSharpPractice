namespace CSharpPracticeTests.Section03Operators.Lesson01Addition;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Theory]
    [InlineData(12, 8, 20)]
    [InlineData(25, 15, 40)]
    [InlineData(0, 9, 9)]
    [InlineData(7, 0, 7)]
    [InlineData(-5, 12, 7)]
    [InlineData(10, -4, 6)]
    [InlineData(-8, -6, -14)]
    [InlineData(-10, 10, 0)]
    public void AddQuestPoints_ReturnsCorrectTotal(
       int currentPoints,
       int earnedPoints,
       int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson01Addition.Exercise01.MainClass
                .AddQuestPoints(currentPoints, earnedPoints);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(350, 125, 475)]
    [InlineData(100, 50, 150)]
    [InlineData(0, 75, 75)]
    [InlineData(200, 0, 200)]
    [InlineData(0, 0, 0)]
    [InlineData(999, 1, 1000)]
    public void CalculateTotalInventory_ReturnsCorrectTotal(
        int warehouseStock,
        int incomingShipment,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson01Addition.Exercise02.MainClass
                .CalculateTotalInventory(warehouseStock, incomingShipment);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(20, 35, 55)]
    [InlineData(-20, 35, 15)]
    [InlineData(40, -15, 25)]
    [InlineData(-30, -25, -55)]
    [InlineData(0, 18, 18)]
    [InlineData(-12, 0, -12)]
    [InlineData(0, 0, 0)]
    [InlineData(-50, 50, 0)]
    public void CalculateAccountChange_ReturnsCorrectCombinedChange(
        int firstAdjustment,
        int secondAdjustment,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson01Addition.Exercise03.MainClass
                .CalculateAccountChange(firstAdjustment, secondAdjustment);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("Morgan", 30, 45, "Player: Morgan | Total Score: 75")]
    [InlineData("Alex", 10, 20, "Player: Alex | Total Score: 30")]
    [InlineData("Jordan", 0, 50, "Player: Jordan | Total Score: 50")]
    [InlineData("Taylor", 25, 0, "Player: Taylor | Total Score: 25")]
    [InlineData("Casey", 0, 0, "Player: Casey | Total Score: 0")]
    [InlineData("Riley", -10, 25, "Player: Riley | Total Score: 15")]
    public void CreateScoreSummary_ReturnsCorrectSummary(
        string playerName,
        int firstRoundScore,
        int secondRoundScore,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section03Operators.Lesson01Addition.Exercise04.MainClass
                .CreateScoreSummary(playerName, firstRoundScore, secondRoundScore);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("Avery", 9, 5, "Customer: Avery | Total Items: 14")]
    [InlineData("Morgan", 20, 10, "Customer: Morgan | Total Items: 30")]
    [InlineData("Taylor", 0, 8, "Customer: Taylor | Total Items: 8")]
    [InlineData("Jordan", 15, 0, "Customer: Jordan | Total Items: 15")]
    [InlineData("Casey", 0, 0, "Customer: Casey | Total Items: 0")]
    [InlineData("Riley", 125, 75, "Customer: Riley | Total Items: 200")]
    public void CreateOrderSummary_ReturnsCorrectSummary(
        string customerName,
        int existingItems,
        int newItems,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section03Operators.Lesson01Addition.Exercise05.MainClass
                .CreateOrderSummary(customerName, existingItems, newItems);

        Assert.Equal(expected, actual);
    }
}