namespace CSharpPracticeTests.Section06Methods.Lesson09RefParameters;
[Trait("Section", "Section06Methods")]
public class ExercisesClass
{
    [Theory]
    [InlineData(10, 25, 25, 10)]
    [InlineData(0, 15, 15, 0)]
    [InlineData(-8, 12, 12, -8)]
    [InlineData(30, -20, -20, 30)]
    [InlineData(7, 7, 7, 7)]
    public void ExchangeCounts_ShouldExchangeValues(
        int firstValue,
        int secondValue,
        int expectedFirst,
        int expectedSecond)
    {
        CSharpPracticeLibrary.Section06Methods.Lesson09RefParameters.Exercise01.MainClass
            .ExchangeCounts(ref firstValue, ref secondValue);

        Assert.Equal(expectedFirst, firstValue);
        Assert.Equal(expectedSecond, secondValue);
    }

    [Theory]
    [InlineData(10, 25, "Warehouse A: 25, Warehouse B: 10")]
    [InlineData(0, 15, "Warehouse A: 15, Warehouse B: 0")]
    [InlineData(-8, 12, "Warehouse A: 12, Warehouse B: -8")]
    [InlineData(30, -20, "Warehouse A: -20, Warehouse B: 30")]
    [InlineData(7, 7, "Warehouse A: 7, Warehouse B: 7")]
    public void ExchangeAndDescribe_ShouldExchangeAndReturnDescription(
        int warehouseA,
        int warehouseB,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson09RefParameters.Exercise01.MainClass
                .ExchangeAndDescribe(warehouseA, warehouseB);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(40, 15, 8, 32, 23)]
    [InlineData(100, 0, 25, 75, 25)]
    [InlineData(10, 20, 0, 10, 20)]
    [InlineData(50, 50, 50, 0, 100)]
    [InlineData(1, 99, 1, 0, 100)]
    public void TransferItems_ShouldModifyBothOriginalQuantities(
       int sourceQuantity,
       int destinationQuantity,
       int amount,
       int expectedSource,
       int expectedDestination)
    {
        CSharpPracticeLibrary.Section06Methods.Lesson09RefParameters.Exercise02.MainClass
            .TransferItems(
                ref sourceQuantity,
                ref destinationQuantity,
                amount);

        Assert.Equal(expectedSource, sourceQuantity);
        Assert.Equal(expectedDestination, destinationQuantity);
    }
    [Theory]
    [InlineData(50, -12, 38)]
    [InlineData(25, 10, 35)]
    [InlineData(100, 0, 100)]
    [InlineData(0, 15, 15)]
    [InlineData(20, -20, 0)]
    [InlineData(-10, 4, -6)]
    public void AdjustBalance_ShouldModifyOriginalBalance(
        int balance,
        int adjustment,
        int expectedBalance)
    {
        CSharpPracticeLibrary.Section06Methods.Lesson09RefParameters.Exercise03.MainClass
            .AdjustBalance(ref balance, adjustment);

        Assert.Equal(expectedBalance, balance);
    }

    [Theory]
    [InlineData(80, 35, 35, 80)]
    [InlineData(20, 60, 20, 60)]
    [InlineData(45, 45, 45, 45)]
    [InlineData(-10, -30, -30, -10)]
    [InlineData(-25, 15, -25, 15)]
    [InlineData(10, -5, -5, 10)]
    public void PutSmallerFirst_ShouldPutValuesInCorrectOrder(
        int firstMeasurement,
        int secondMeasurement,
        int expectedFirst,
        int expectedSecond)
    {
        CSharpPracticeLibrary.Section06Methods.Lesson09RefParameters.Exercise04.MainClass
            .PutSmallerFirst(
                ref firstMeasurement,
                ref secondMeasurement);

        Assert.Equal(expectedFirst, firstMeasurement);
        Assert.Equal(expectedSecond, secondMeasurement);
    }
    [Theory]
    [InlineData(120, -15, 105)]
    [InlineData(50, 20, 70)]
    [InlineData(100, 0, 100)]
    [InlineData(10, -10, 0)]
    [InlineData(0, 25, 25)]
    [InlineData(-10, 5, -5)]
    public void ApplyInventoryCorrection_ShouldModifyOriginalInventory(
        int inventoryCount,
        int correction,
        int expectedInventory)
    {
        CSharpPracticeLibrary.Section06Methods.Lesson09RefParameters.Exercise05.MainClass
            .ApplyInventoryCorrection(
                ref inventoryCount,
                correction);

        Assert.Equal(expectedInventory, inventoryCount);
    }

    [Theory]
    [InlineData(120, 30, -15, 5, 105, 35)]
    [InlineData(50, 20, 10, -8, 60, 12)]
    [InlineData(100, 40, 0, 0, 100, 40)]
    [InlineData(10, 5, -10, -5, 0, 0)]
    [InlineData(0, 0, 25, 12, 25, 12)]
    public void ReconcileInventory_ShouldCorrectBothOriginalValues(
        int warehouseCount,
        int reservedCount,
        int warehouseCorrection,
        int reservedCorrection,
        int expectedWarehouse,
        int expectedReserved)
    {
        CSharpPracticeLibrary.Section06Methods.Lesson09RefParameters.Exercise05.MainClass
            .ReconcileInventory(
                ref warehouseCount,
                ref reservedCount,
                warehouseCorrection,
                reservedCorrection);

        Assert.Equal(expectedWarehouse, warehouseCount);
        Assert.Equal(expectedReserved, reservedCount);
    }
}