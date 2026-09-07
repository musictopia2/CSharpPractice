namespace CSharpPracticeTests.Section06Methods.Lesson08ParamsArguments;
[Trait("Section", "Section06Methods")]
public class ExercisesClass
{
    [Theory]
    [InlineData(0)]
    [InlineData(12, 12)]
    [InlineData(25, 10, 15)]
    [InlineData(60, 10, 20, 30)]
    [InlineData(100, 5, 15, 20, 25, 35)]
    public void CalculateTotalWeight_ReturnsExpectedTotal(
       int expected,
       params int[] packageWeights)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson08ParamsArguments
                .Exercise01.MainClass.CalculateTotalWeight([.. packageWeights]);

        Assert.Equal(expected, actual);
    }
    public static TheoryData<decimal, decimal, decimal[]> SupplyCostTestData =>
    new()
    {
        { 5.00m, 5.00m, [] },
        { 17.50m, 5.00m, [12.50m] },
        { 35.75m, 5.75m, [10.00m, 20.00m] },
        { 82.25m, 7.25m, [15.00m, 25.00m, 35.00m] }
    };

    [Theory]
    [MemberData(nameof(SupplyCostTestData))]
    public void CalculateSupplyCost_ReturnsExpectedTotal(
        decimal expected,
        decimal shippingFee,
        decimal[] itemPrices)
    {
        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson08ParamsArguments
                .Exercise02.MainClass.CalculateSupplyCost(
                    shippingFee,
                    [.. itemPrices]);

        Assert.Equal(expected, actual);
    }
    public static TheoryData<int, int, int[]> LargestReadingTestData =>
    new()
    {
        { 50, 50, [] },
        { 25, 100, [25] },
        { 35, 100, [20, 35, 15] },
        { -5, 10, [-20, -5, -30] },
        { 12, -100, [4, 12, 8, 3] }
    };

    [Theory]
    [MemberData(nameof(LargestReadingTestData))]
    public void FindLargestReading_ReturnsExpectedValue(
        int expected,
        int defaultReading,
        int[] readings)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson08ParamsArguments
                .Exercise03.MainClass.FindLargestReading(
                    defaultReading,
                    [.. readings]);

        Assert.Equal(expected, actual);
    }
    public static TheoryData<int, int, int[]> CountAtOrAboveTestData =>
    new()
    {
        { 0, 10, [] },
        { 2, 10, [5, 10, 14, 7] },
        { 3, 20, [20, 20, 25, 19] },
        { 0, 50, [10, 20, 30] },
        { 3, 0, [-5, 0, 4, -1, 10] },
        { 2, -5, [-10, -5, -2, -20] }
    };

    [Theory]
    [MemberData(nameof(CountAtOrAboveTestData))]
    public void CountAtOrAbove_ReturnsExpectedCount(
        int expected,
        int minimum,
        int[] values)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson08ParamsArguments
                .Exercise04.MainClass.CountAtOrAbove(
                    minimum,
                    [.. values]);

        Assert.Equal(expected, actual);
    }

    public static TheoryData<string, string, int, int[]> InventoryAlertTestData =>
    new()
    {
        { "Widget: 0 units - Low Stock", "Widget", 10, [] },
        { "Bolts: 25 units - Sufficient", "Bolts", 25, [10, 15] },
        { "Cables: 40 units - Sufficient", "Cables", 30, [10, 12, 18] },
        { "Panels: 18 units - Low Stock", "Panels", 25, [5, 6, 7] },
        { "Sensors: 50 units - Sufficient", "Sensors", 50, [20, 10, 5, 15] }
    };

    [Theory]
    [MemberData(nameof(InventoryAlertTestData))]
    public void CreateInventoryAlert_ReturnsExpectedMessage(
        string expected,
        string productName,
        int minimumStock,
        int[] warehouseStock)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson08ParamsArguments
                .Exercise05.MainClass.CreateInventoryAlert(
                    productName,
                    minimumStock,
                    [.. warehouseStock]);

        Assert.Equal(expected, actual);
    }


}