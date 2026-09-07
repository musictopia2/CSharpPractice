namespace CSharpPracticeTests.Section06Methods.Lesson12Review;
[Trait("Section", "Section06Methods")]
public class ExercisesClass
{
    [Theory]
    [InlineData(new int[] { }, 0)]
    [InlineData(new int[] { 5 }, 5)]
    [InlineData(new int[] { 4, 7, 3 }, 14)]
    [InlineData(new int[] { 10, 0, 6, 2 }, 18)]
    public void CalculateTotalItems_ReturnsExpectedTotal(
        int[] quantities,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise01.MainClass
                .CalculateTotalItems([.. quantities]);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(23, 5, true, 4, 3)]
    [InlineData(20, 5, true, 4, 0)]
    [InlineData(3, 10, true, 0, 3)]
    [InlineData(0, 5, true, 0, 0)]
    [InlineData(-1, 5, false, 0, 0)]
    [InlineData(10, 0, false, 0, 0)]
    [InlineData(10, -2, false, 0, 0)]
    public void CalculatePackingDetails_ReturnsExpectedResults(
        int totalItems,
        int boxCapacity,
        bool expectedResult,
        int expectedCompleteBoxes,
        int expectedRemainingItems)
    {
        bool actualResult =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise01.MainClass
                .CalculatePackingDetails(
                    totalItems,
                    boxCapacity,
                    out int completeBoxes,
                    out int remainingItems);

        Assert.Equal(expectedResult, actualResult);
        Assert.Equal(expectedCompleteBoxes, completeBoxes);
        Assert.Equal(expectedRemainingItems, remainingItems);
    }

    [Theory]
    [InlineData(4, 3, "Packing: 4 complete boxes, 3 remaining items")]
    [InlineData(0, 7, "Packing: 0 complete boxes, 7 remaining items")]
    [InlineData(6, 0, "Packing: 6 complete boxes, 0 remaining items")]
    public void CreatePackingMessage_UsingDefaultLabel_ReturnsExpectedMessage(
        int completeBoxes,
        int remainingItems,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise01.MainClass
                .CreatePackingMessage(
                    completeBoxes: completeBoxes,
                    remainingItems: remainingItems);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 1, "Order", "Order: 2 complete boxes, 1 remaining items")]
    [InlineData(8, 0, "Shipment", "Shipment: 8 complete boxes, 0 remaining items")]
    [InlineData(0, 4, "Delivery", "Delivery: 0 complete boxes, 4 remaining items")]
    public void CreatePackingMessage_WithSpecifiedLabel_ReturnsExpectedMessage(
        int completeBoxes,
        int remainingItems,
        string label,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise01.MainClass
                .CreatePackingMessage(
                    remainingItems: remainingItems,
                    label: label,
                    completeBoxes: completeBoxes);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(100, 25, 125)]
    [InlineData(0, 40, 40)]
    [InlineData(75, 0, 75)]
    [InlineData(-10, 5, -5)]
    public void CalculateAdjustedProduction_UsingDefaultMultiplier_ReturnsExpectedResult(
        int baseProduction,
        int bonusProduction,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise02.MainClass
                .CalculateAdjustedProduction(
                    baseProduction,
                    bonusProduction);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(100, 25, 2, 250)]
    [InlineData(10, 5, 3, 45)]
    [InlineData(0, 20, 4, 80)]
    [InlineData(50, -10, 2, 80)]
    public void CalculateAdjustedProduction_WithMultiplier_ReturnsExpectedResult(
        int baseProduction,
        int bonusProduction,
        int multiplier,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise02.MainClass
                .CalculateAdjustedProduction(
                    bonusProduction: bonusProduction,
                    multiplier: multiplier,
                    baseProduction: baseProduction);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(40, 10, 100, true, 50)]
    [InlineData(40, 60, 100, true, 100)]
    [InlineData(0, 25, 50, true, 25)]
    public void TryApplyProduction_ValidAmount_UpdatesProduction(
        int startingProduction,
        int amountToAdd,
        int maximumProduction,
        bool expectedResult,
        int expectedProduction)
    {
        int currentProduction = startingProduction;

        bool actualResult =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise02.MainClass
                .TryApplyProduction(
                    ref currentProduction,
                    amountToAdd,
                    maximumProduction);

        Assert.Equal(expectedResult, actualResult);
        Assert.Equal(expectedProduction, currentProduction);
    }

    [Theory]
    [InlineData(40, -1, 100)]
    [InlineData(90, 11, 100)]
    [InlineData(100, 1, 100)]
    public void TryApplyProduction_InvalidAmount_DoesNotChangeProduction(
        int startingProduction,
        int amountToAdd,
        int maximumProduction)
    {
        int currentProduction = startingProduction;

        bool actualResult =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise02.MainClass
                .TryApplyProduction(
                    ref currentProduction,
                    amountToAdd,
                    maximumProduction);

        Assert.False(actualResult);
        Assert.Equal(startingProduction, currentProduction);
    }

    [Theory]
    [InlineData(100, 100, true)]
    [InlineData(125, 100, true)]
    [InlineData(99, 100, false)]
    [InlineData(0, 1, false)]
    public void IsProductionTargetReached_ReturnsExpectedResult(
        int currentProductionValue,
        int targetProduction,
        bool expected)
    {
        int currentProduction = currentProductionValue;

        bool actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise02.MainClass
                .IsProductionTargetReached(
                    in currentProduction,
                    targetProduction);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(20, 30, 50, 30)]
    [InlineData(0, 10, 25, 25)]
    [InlineData(29, 30, 40, 11)]
    [InlineData(30, 30, 50, 0)]
    [InlineData(40, 30, 50, 0)]
    public void CalculateReorderAmount_ReturnsExpectedAmount(
        int currentStock,
        int minimumStock,
        int targetStock,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise03.MainClass
                .CalculateReorderAmount(
                    currentStock,
                    minimumStock,
                    targetStock);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(20, 30, 50, "Reorder 30 items")]
    [InlineData(0, 10, 25, "Reorder 25 items")]
    [InlineData(29, 30, 40, "Reorder 11 items")]
    [InlineData(30, 30, 50, "No reorder needed")]
    [InlineData(40, 30, 50, "No reorder needed")]
    public void CreateReorderMessage_ReturnsExpectedMessage(
        int currentStock,
        int minimumStock,
        int targetStock,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise03.MainClass
                .CreateReorderMessage(
                    currentStock,
                    minimumStock,
                    targetStock);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(20, 30, 50, "Reorder 30 items")]
    [InlineData(30, 30, 50, "No reorder needed")]
    [InlineData(45, 30, 50, "No reorder needed")]
    public void DisplayReorderMessage_DisplaysExpectedMessage(
        int currentStock,
        int minimumStock,
        int targetStock,
        string expected)
    {
        StringWriter writer = new();
        TextWriter originalOutput = Console.Out;

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise03.MainClass
                .DisplayReorderMessage(
                    currentStock,
                    minimumStock,
                    targetStock);
        }
        finally
        {
            Console.SetOut(originalOutput);
        }

        string actual = writer.ToString().TrimEnd('\r', '\n');

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(4, 2.50, 10.00)]
    [InlineData(0, 5.25, 0.00)]
    [InlineData(7, 1.10, 7.70)]
    public void CalculateShippingCost_WithoutHandlingFee_ReturnsExpectedResult(
        int packageCount,
        double costPerPackageValue,
        double expectedValue)
    {
        decimal costPerPackage = (decimal)costPerPackageValue;
        decimal expected = (decimal)expectedValue;

        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise04.MainClass
                .CalculateShippingCost(
                    packageCount,
                    costPerPackage);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(4, 2.50, 3.00, 13.00)]
    [InlineData(1, 8.75, 1.25, 10.00)]
    [InlineData(0, 5.00, 2.50, 2.50)]
    public void CalculateShippingCost_WithHandlingFee_ReturnsExpectedResult(
        int packageCount,
        double costPerPackageValue,
        double handlingFeeValue,
        double expectedValue)
    {
        decimal costPerPackage = (decimal)costPerPackageValue;
        decimal handlingFee = (decimal)handlingFeeValue;
        decimal expected = (decimal)expectedValue;

        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise04.MainClass
                .CalculateShippingCost(
                    packageCount,
                    costPerPackage,
                    handlingFee);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 2.00, 1.50, 11.50)]
    [InlineData(2, 10.00, 0.00, 20.00)]
    [InlineData(0, 4.00, 3.00, 3.00)]
    public void TryCalculateShippingCost_ValidValues_ReturnsTrueAndExpectedCost(
        int packageCount,
        double costPerPackageValue,
        double handlingFeeValue,
        double expectedValue)
    {
        decimal costPerPackage = (decimal)costPerPackageValue;
        decimal handlingFee = (decimal)handlingFeeValue;
        decimal expected = (decimal)expectedValue;

        bool actualResult =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise04.MainClass
                .TryCalculateShippingCost(
                    packageCount,
                    costPerPackage,
                    handlingFee,
                    out decimal shippingCost);

        Assert.True(actualResult);
        Assert.Equal(expected, shippingCost);
    }

    [Theory]
    [InlineData(-1, 2.00, 1.00)]
    [InlineData(5, -2.00, 1.00)]
    [InlineData(5, 2.00, -1.00)]
    public void TryCalculateShippingCost_InvalidValues_ReturnsFalseAndZero(
        int packageCount,
        double costPerPackageValue,
        double handlingFeeValue)
    {
        decimal costPerPackage = (decimal)costPerPackageValue;
        decimal handlingFee = (decimal)handlingFeeValue;

        bool actualResult =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise04.MainClass
                .TryCalculateShippingCost(
                    packageCount,
                    costPerPackage,
                    handlingFee,
                    out decimal shippingCost);

        Assert.False(actualResult);
        Assert.Equal(0m, shippingCost);
    }

    [Theory]
    [InlineData(4, 25.50, "4 packages cost $25.50")]
    [InlineData(1, 10.00, "1 packages cost $10.00")]
    [InlineData(0, 0.00, "0 packages cost $0.00")]
    public void CreateShippingSummary_ReturnsExpectedMessage(
        int packageCount,
        double shippingCostValue,
        string expected)
    {
        decimal shippingCost = (decimal)shippingCostValue;

        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise04.MainClass
                .CreateShippingSummary(
                    packageCount,
                    shippingCost);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2.50, new int[] { }, 0.00)]
    [InlineData(2.50, new int[] { 4 }, 10.00)]
    [InlineData(1.25, new int[] { 2, 3, 1 }, 7.50)]
    [InlineData(10.00, new int[] { 0, 2, 0 }, 20.00)]
    public void CalculateOrderTotal_ReturnsExpectedTotal(
       double pricePerItemValue,
       int[] quantities,
       double expectedValue)
    {
        decimal pricePerItem = (decimal)pricePerItemValue;
        decimal expected = (decimal)expectedValue;

        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise05.MainClass
                .CalculateOrderTotal(
                    pricePerItem,
                    [.. quantities]);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 3, 10, true, 8)]
    [InlineData(5, 5, 10, true, 10)]
    [InlineData(0, 4, 10, true, 4)]
    [InlineData(10, 0, 10, true, 10)]
    public void TryAddItems_ValidAmount_UpdatesItemCount(
        int startingItemCount,
        int itemsToAdd,
        int maximumItems,
        bool expectedResult,
        int expectedItemCount)
    {
        int currentItemCount = startingItemCount;

        bool actualResult =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise05.MainClass
                .TryAddItems(
                    ref currentItemCount,
                    itemsToAdd,
                    maximumItems);

        Assert.Equal(expectedResult, actualResult);
        Assert.Equal(expectedItemCount, currentItemCount);
    }

    [Theory]
    [InlineData(5, -1, 10)]
    [InlineData(8, 3, 10)]
    [InlineData(10, 1, 10)]
    public void TryAddItems_InvalidAmount_DoesNotChangeItemCount(
        int startingItemCount,
        int itemsToAdd,
        int maximumItems)
    {
        int currentItemCount = startingItemCount;

        bool actualResult =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise05.MainClass
                .TryAddItems(
                    ref currentItemCount,
                    itemsToAdd,
                    maximumItems);

        Assert.False(actualResult);
        Assert.Equal(startingItemCount, currentItemCount);
    }

    [Theory]
    [InlineData(5, 5, "Ready")]
    [InlineData(8, 5, "Ready")]
    [InlineData(4, 5, "Waiting")]
    [InlineData(0, 1, "Waiting")]
    public void GetOrderStatus_ReturnsExpectedStatus(
        int currentItemCountValue,
        int minimumItems,
        string expected)
    {
        int currentItemCount = currentItemCountValue;

        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise05.MainClass
                .GetOrderStatus(
                    currentItemCount,
                    minimumItems);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 25.00, "Standard order: 5 items totaling $25.00")]
    [InlineData(0, 0.00, "Standard order: 0 items totaling $0.00")]
    [InlineData(12, 18.75, "Standard order: 12 items totaling $18.75")]
    public void CreateOrderSummary_UsingDefaultCustomerType_ReturnsExpectedMessage(
        int itemCount,
        double orderTotalValue,
        string expected)
    {
        decimal orderTotal = (decimal)orderTotalValue;

        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise05.MainClass
                .CreateOrderSummary(
                    itemCount,
                    orderTotal);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 25.00, "Priority", "Priority order: 5 items totaling $25.00")]
    [InlineData(3, 12.50, "Wholesale", "Wholesale order: 3 items totaling $12.50")]
    [InlineData(1, 7.25, "Express", "Express order: 1 items totaling $7.25")]
    public void CreateOrderSummary_WithCustomerType_ReturnsExpectedMessage(
        int itemCount,
        double orderTotalValue,
        string customerType,
        string expected)
    {
        decimal orderTotal = (decimal)orderTotalValue;

        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise05.MainClass
                .CreateOrderSummary(
                    orderTotal: orderTotal,
                    customerType: customerType,
                    itemCount: itemCount);

        Assert.Equal(expected, actual);
    }


}