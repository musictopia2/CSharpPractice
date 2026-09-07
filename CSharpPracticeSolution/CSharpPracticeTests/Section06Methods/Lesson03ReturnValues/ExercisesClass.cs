namespace CSharpPracticeTests.Section06Methods.Lesson03ReturnValues;
[Trait("Section", "Section06Methods")]
public class ExercisesClass
{
    [Theory]
    [InlineData(4, 6, 24)]
    [InlineData(7, 3, 21)]
    [InlineData(1, 12, 12)]
    [InlineData(8, 5, 40)]
    [InlineData(10, 9, 90)]
    public void CalculateTotalItems_ReturnsCorrectTotal(
        int numberOfPackages,
        int itemsPerPackage,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson03ReturnValues.Exercise01
                .MainClass.CalculateTotalItems(
                    numberOfPackages,
                    itemsPerPackage);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(100, 35, 65)]
    [InlineData(250, 100, 150)]
    [InlineData(80, 80, 0)]
    [InlineData(500, 125, 375)]
    [InlineData(60, 10, 50)]
    public void CalculateMilesRemaining_ReturnsCorrectAmount(
        int totalMiles,
        int milesCompleted,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson03ReturnValues.Exercise02
                .MainClass.CalculateMilesRemaining(
                    totalMiles,
                    milesCompleted);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("Bolts", 25, "Item: Bolts - Quantity: 25")]
    [InlineData("Washers", 8, "Item: Washers - Quantity: 8")]
    [InlineData("Safety Gloves", 0, "Item: Safety Gloves - Quantity: 0")]
    [InlineData("Bearings", 42, "Item: Bearings - Quantity: 42")]
    [InlineData("Hydraulic Pump", 3, "Item: Hydraulic Pump - Quantity: 3")]
    public void CreateStockMessage_ReturnsCorrectMessage(
        string itemName,
        int quantity,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson03ReturnValues.Exercise03
                .MainClass.CreateStockMessage(
                    itemName,
                    quantity);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, 4.00, 40.00)]
    [InlineData(19, 5.00, 95.00)]
    [InlineData(20, 5.00, 90.00)]
    [InlineData(30, 2.00, 54.00)]
    [InlineData(25, 8.00, 180.00)]
    public void CalculateOrderTotal_ReturnsCorrectTotal(
        int quantity,
        decimal pricePerItem,
        decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson03ReturnValues.Exercise04
                .MainClass.CalculateOrderTotal(
                    quantity,
                    pricePerItem);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(75, 8, 67)]
    [InlineData(100, 0, 100)]
    [InlineData(50, 10, 40)]
    [InlineData(25, 25, 0)]
    [InlineData(120, 17, 103)]
    public void CalculatePassedInspections_ReturnsCorrectAmount(
        int totalInspected,
        int failedInspections,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson03ReturnValues.Exercise05
                .MainClass.CalculatePassedInspections(
                    totalInspected,
                    failedInspections);

        Assert.Equal(expected, actual);
    }
}