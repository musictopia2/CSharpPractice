namespace CSharpPracticeTests.Section06Methods.Lesson10OutParameters;
[Trait("Section", "Section06Methods")]
public class ExercisesClass
{
    [Theory]
    [InlineData(23, 5, true, 4, 3)]
    [InlineData(18, 6, true, 3, 0)]
    [InlineData(17, 4, true, 4, 1)]
    [InlineData(5, 8, true, 0, 5)]
    [InlineData(15, 0, false, 0, 0)]
    [InlineData(0, 0, false, 0, 0)]
    public void SplitShipment_ReturnsExpectedResults(
        int totalItems,
        int containerCount,
        bool expectedSuccess,
        int expectedItemsPerContainer,
        int expectedRemainingItems)
    {
        bool result =
            CSharpPracticeLibrary.Section06Methods.Lesson10OutParameters.Exercise01.MainClass.SplitShipment(
                totalItems,
                containerCount,
                out int itemsPerContainer,
                out int remainingItems);

        Assert.Equal(expectedSuccess, result);
        Assert.Equal(expectedItemsPerContainer, itemsPerContainer);
        Assert.Equal(expectedRemainingItems, remainingItems);
    }
    [Theory]
    [InlineData(52, 10, true, 5, 2)]
    [InlineData(24, 6, true, 4, 0)]
    [InlineData(7, 10, true, 0, 7)]
    [InlineData(100, 9, true, 11, 1)]
    [InlineData(30, 0, false, 0, 0)]
    [InlineData(30, -5, false, 0, 0)]
    public void CalculateBoxes_ReturnsExpectedResults(
       int itemCount,
       int boxCapacity,
       bool expectedSuccess,
       int expectedFullBoxes,
       int expectedLeftoverItems)
    {
        bool result =
            CSharpPracticeLibrary.Section06Methods.Lesson10OutParameters.Exercise02.MainClass.CalculateBoxes(
                itemCount,
                boxCapacity,
                out int fullBoxes,
                out int leftoverItems);

        Assert.Equal(expectedSuccess, result);
        Assert.Equal(expectedFullBoxes, fullBoxes);
        Assert.Equal(expectedLeftoverItems, leftoverItems);
    }
    [Theory]
    [InlineData(145, true, 2, 25)]
    [InlineData(300, true, 5, 0)]
    [InlineData(42, true, 0, 42)]
    [InlineData(0, true, 0, 0)]
    [InlineData(59, true, 0, 59)]
    [InlineData(60, true, 1, 0)]
    [InlineData(-30, false, 0, 0)]
    public void CalculateTime_ReturnsExpectedResults(
        int totalSeconds,
        bool expectedSuccess,
        int expectedMinutes,
        int expectedSeconds)
    {
        bool result =
            CSharpPracticeLibrary.Section06Methods.Lesson10OutParameters.Exercise03.MainClass.CalculateTime(
                totalSeconds,
                out int minutes,
                out int seconds);

        Assert.Equal(expectedSuccess, result);
        Assert.Equal(expectedMinutes, minutes);
        Assert.Equal(expectedSeconds, seconds);
    }

    [Theory]
    [InlineData(4, 12.50, 10, true, 50.00, 5.00, 45.00)]
    [InlineData(3, 20.00, 0, true, 60.00, 0.00, 60.00)]
    [InlineData(5, 8.00, 25, true, 40.00, 10.00, 30.00)]
    [InlineData(2, 15.00, 100, true, 30.00, 30.00, 0.00)]
    [InlineData(1, 0.00, 50, true, 0.00, 0.00, 0.00)]
    [InlineData(0, 10.00, 10, false, 0.00, 0.00, 0.00)]
    [InlineData(-2, 10.00, 10, false, 0.00, 0.00, 0.00)]
    [InlineData(3, -5.00, 10, false, 0.00, 0.00, 0.00)]
    [InlineData(3, 10.00, -1, false, 0.00, 0.00, 0.00)]
    [InlineData(3, 10.00, 101, false, 0.00, 0.00, 0.00)]
    public void CalculateOrder_ReturnsExpectedResults(
        int quantity,
        double pricePerItem,
        int discountPercent,
        bool expectedSuccess,
        double expectedSubtotal,
        double expectedDiscountAmount,
        double expectedFinalTotal)
    {
        bool result =
            CSharpPracticeLibrary.Section06Methods.Lesson10OutParameters.Exercise04.MainClass.CalculateOrder(
                quantity,
                (decimal)pricePerItem,
                discountPercent,
                out decimal subtotal,
                out decimal discountAmount,
                out decimal finalTotal);

        Assert.Equal(expectedSuccess, result);
        Assert.Equal((decimal)expectedSubtotal, subtotal);
        Assert.Equal((decimal)expectedDiscountAmount, discountAmount);
        Assert.Equal((decimal)expectedFinalTotal, finalTotal);
    }
    [Theory]
    [InlineData(87, 20, 80, true, 4, 7, true)]
    [InlineData(45, 10, 50, true, 4, 5, false)]
    [InlineData(100, 25, 100, true, 4, 0, true)]
    [InlineData(0, 10, 50, true, 0, 0, false)]
    [InlineData(-1, 10, 50, false, 0, 0, false)]
    [InlineData(50, 0, 40, false, 0, 0, false)]
    [InlineData(50, -5, 40, false, 0, 0, false)]
    [InlineData(50, 10, 0, false, 0, 0, false)]
    [InlineData(50, 10, -20, false, 0, 0, false)]
    public void GetProductionSummary_ReturnsExpectedResults(
        int itemsProduced,
        int batchSize,
        int productionTarget,
        bool expectedSuccess,
        int expectedCompleteBatches,
        int expectedRemainingItems,
        bool expectedTargetReached)
    {
        bool result =
            CSharpPracticeLibrary.Section06Methods.Lesson10OutParameters.Exercise05.MainClass.GetProductionSummary(
                itemsProduced,
                batchSize,
                productionTarget,
                out int completeBatches,
                out int remainingItems,
                out bool targetReached);

        Assert.Equal(expectedSuccess, result);
        Assert.Equal(expectedCompleteBatches, completeBatches);
        Assert.Equal(expectedRemainingItems, remainingItems);
        Assert.Equal(expectedTargetReached, targetReached);
    }
}