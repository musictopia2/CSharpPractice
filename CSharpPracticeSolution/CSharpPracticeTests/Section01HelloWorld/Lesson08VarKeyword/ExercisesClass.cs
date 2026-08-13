namespace CSharpPracticeTests.Section01HelloWorld.Lesson08VarKeyword;
[Trait("Section", "Section01HelloWorld")]
public class ExercisesClass
{
    [Theory]
    [InlineData(4, 12)]
    [InlineData(7, 21)]
    [InlineData(0, 0)]
    [InlineData(-3, -9)]
    [InlineData(-8, -24)]
    public void CalculateBonusPoints_ReturnsPointsMultipliedByThree(
        int points,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson08VarKeyword.Exercise01
                .MainClass.CalculateBonusPoints(points);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(20.0, 10.0)]
    [InlineData(15.0, 7.5)]
    [InlineData(0.0, 0.0)]
    [InlineData(9.5, 4.75)]
    [InlineData(25.5, 12.75)]
    public void CalculateHalfPrice_ReturnsHalfOfPrice(
        double price,
        double expected)
    {
        double actual =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson08VarKeyword.Exercise02
                .MainClass.CalculateHalfPrice(price);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("Ready", "System status: Ready")]
    [InlineData("Running", "System status: Running")]
    [InlineData("Offline", "System status: Offline")]
    [InlineData("Updating", "System status: Updating")]
    [InlineData("", "System status: ")]
    public void CreateStatusMessage_ReturnsCorrectMessage(
        string status,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson08VarKeyword.Exercise03
                .MainClass.CreateStatusMessage(status);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("Notebook", 3, "Item: Notebook, Total units: 6")]
    [InlineData("Marker", 5, "Item: Marker, Total units: 10")]
    [InlineData("Folder", 0, "Item: Folder, Total units: 0")]
    [InlineData("Pencil", 1, "Item: Pencil, Total units: 2")]
    [InlineData("Binder", 8, "Item: Binder, Total units: 16")]
    public void CreateOrderSummary_ReturnsCorrectSummary(
       string itemName,
       int quantity,
       string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson08VarKeyword.Exercise04
                .MainClass.CreateOrderSummary(itemName, quantity);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("Books", 3, "Product: Books, Boxes: 3, Estimated weight: 15 pounds")]
    [InlineData("Games", 6, "Product: Games, Boxes: 6, Estimated weight: 30 pounds")]
    [InlineData("Cables", 0, "Product: Cables, Boxes: 0, Estimated weight: 0 pounds")]
    [InlineData("Monitors", 1, "Product: Monitors, Boxes: 1, Estimated weight: 5 pounds")]
    [InlineData("Keyboards", 8, "Product: Keyboards, Boxes: 8, Estimated weight: 40 pounds")]
    public void CreateShippingEstimate_ReturnsCorrectEstimate(
        string productName,
        int boxCount,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson08VarKeyword.Exercise05
                .MainClass.CreateShippingEstimate(productName, boxCount);

        Assert.Equal(expected, actual);
    }
}