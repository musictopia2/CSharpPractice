namespace CSharpPracticeTests.Section06Methods.Lesson04UsingReturnValues;
[Trait("Section", "Section06Methods")]
public class ExercisesClass
{
    [Theory]
    [InlineData(4, 6, 24)]
    [InlineData(10, 3, 30)]
    [InlineData(0, 8, 0)]
    [InlineData(5, 0, 0)]
    [InlineData(-3, 4, -12)]
    public void GetItemsPerShipment_ReturnsExpectedResult(
        int boxes,
        int itemsPerBox,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise01.MainClass
            .GetItemsPerShipment(boxes, itemsPerBox);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(4, 6, 3, 72)]
    [InlineData(10, 3, 5, 150)]
    [InlineData(0, 8, 4, 0)]
    [InlineData(5, 0, 7, 0)]
    [InlineData(3, 4, 0, 0)]
    [InlineData(-3, 4, 2, -24)]
    public void GetTotalItems_ReturnsExpectedResult(
        int boxes,
        int itemsPerBox,
        int shipments,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise01.MainClass
            .GetTotalItems(boxes, itemsPerBox, shipments);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(4, 25, 100)]
    [InlineData(10, 12, 120)]
    [InlineData(1, 50, 50)]
    [InlineData(0, 30, 0)]
    [InlineData(8, 0, 0)]
    public void Exercise02_GetDailyProduction_ReturnsExpectedResult(
    int machines,
    int unitsPerMachine,
    int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise02.MainClass
            .GetDailyProduction(machines, unitsPerMachine);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(4, 25, 5, 500)]
    [InlineData(10, 12, 7, 840)]
    [InlineData(1, 50, 3, 150)]
    [InlineData(0, 30, 5, 0)]
    [InlineData(8, 20, 0, 0)]
    public void Exercise02_GetWeeklyProduction_ReturnsExpectedResult(
        int machines,
        int unitsPerMachine,
        int workingDays,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise02.MainClass
            .GetWeeklyProduction(machines, unitsPerMachine, workingDays);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(8, 25, 200)]
    [InlineData(5, 10, 50)]
    [InlineData(1, 30, 30)]
    [InlineData(0, 25, 0)]
    [InlineData(10, 0, 0)]
    public void Exercise03_GetItemsShipped_ReturnsExpectedResult(
    int orders,
    int itemsPerOrder,
    int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise03.MainClass
            .GetItemsShipped(orders, itemsPerOrder);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(500, 8, 25, 300)]
    [InlineData(200, 5, 10, 150)]
    [InlineData(100, 1, 30, 70)]
    [InlineData(250, 0, 25, 250)]
    [InlineData(400, 10, 0, 400)]
    [InlineData(100, 6, 20, -20)]
    public void Exercise03_GetRemainingInventory_ReturnsExpectedResult(
        int startingInventory,
        int orders,
        int itemsPerOrder,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise03.MainClass
            .GetRemainingInventory(
                startingInventory,
                orders,
                itemsPerOrder);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(4, 12.50, 50.00)]
    [InlineData(3, 7.25, 21.75)]
    [InlineData(1, 19.99, 19.99)]
    [InlineData(0, 15.50, 0.00)]
    [InlineData(8, 0.00, 0.00)]
    public void Exercise04_GetMerchandiseCost_ReturnsExpectedResult(
    int quantity,
    decimal pricePerItem,
    decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise04.MainClass
            .GetMerchandiseCost(quantity, pricePerItem);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(4, 12.50, 7.25, 57.25)]
    [InlineData(3, 7.25, 5.00, 26.75)]
    [InlineData(1, 19.99, 0.00, 19.99)]
    [InlineData(0, 15.50, 8.00, 8.00)]
    [InlineData(8, 0.00, 4.50, 4.50)]
    public void Exercise04_GetOrderTotal_ReturnsExpectedResult(
        int quantity,
        decimal pricePerItem,
        decimal deliveryCharge,
        decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise04.MainClass
            .GetOrderTotal(
                quantity,
                pricePerItem,
                deliveryCharge);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5, 8.50, 42.50)]
    [InlineData(3, 12.25, 36.75)]
    [InlineData(1, 19.99, 19.99)]
    [InlineData(0, 10.00, 0.00)]
    [InlineData(6, 0.00, 0.00)]
    public void Exercise05_CalculateShippingCost_ReturnsExpectedResult(
    int packageCount,
    decimal pricePerPackage,
    decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise05.MainClass
            .CalculateShippingCost(
                packageCount,
                pricePerPackage);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 8.50, 7.25, 49.75)]
    [InlineData(3, 12.25, 4.50, 41.25)]
    [InlineData(1, 19.99, 0.00, 19.99)]
    [InlineData(0, 10.00, 6.50, 6.50)]
    [InlineData(6, 0.00, 3.25, 3.25)]
    public void Exercise05_CalculateInvoiceTotal_ReturnsExpectedResult(
        int packageCount,
        decimal pricePerPackage,
        decimal serviceFee,
        decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise05.MainClass
            .CalculateInvoiceTotal(
                packageCount,
                pricePerPackage,
                serviceFee);

        Assert.Equal(expected, actual);
    }
}