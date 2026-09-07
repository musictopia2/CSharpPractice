namespace CSharpPracticeTests.Section06Methods.Lesson02MethodParameters;
[Trait("Section", "Section06Methods")]
public class ExercisesClass
{
    [Theory]
    [InlineData(24, 17, "41")]
    [InlineData(10, 5, "15")]
    [InlineData(0, 8, "8")]
    [InlineData(-5, 12, "7")]
    [InlineData(20, -7, "13")]
    public void DisplayProductionTotal_PrintsTotal(
        int firstShiftUnits,
        int secondShiftUnits,
        string expected)
    {
        using StringWriter output = new();
        Console.SetOut(output);

        CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise01.MainClass
            .DisplayProductionTotal(firstShiftUnits, secondShiftUnits);

        string actual = output.ToString().Trim();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Main_PrintsRequiredProductionTotal()
    {
        using StringWriter output = new();
        Console.SetOut(output);

        CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise01.MainClass
            .Main();

        string actual = output.ToString().Trim();

        Assert.Equal("41", actual);
    }
    [Theory]
    [InlineData(32, 9, "41")]
    [InlineData(10, 4, "14")]
    [InlineData(0, 6, "6")]
    [InlineData(-3, 8, "5")]
    [InlineData(20, -5, "15")]
    public void DisplayShippingTotal_PrintsTotal(
        int standardPackages,
        int expressPackages,
        string expected)
    {
        using StringWriter output = new();
        Console.SetOut(output);

        CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise02.MainClass
            .DisplayShippingTotal(standardPackages, expressPackages);

        string actual = output.ToString().Trim();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Main_PrintsRequiredShippingTotal()
    {
        using StringWriter output = new();
        Console.SetOut(output);

        CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise02.MainClass
            .Main();

        string actual = output.ToString().Trim();

        Assert.Equal("41", actual);
    }
    [Theory]
    [InlineData("Bolts", 75, "Product: Bolts - Quantity: 75")]
    [InlineData("Washers", 20, "Product: Washers - Quantity: 20")]
    [InlineData("Gears", 0, "Product: Gears - Quantity: 0")]
    [InlineData("Panels", 125, "Product: Panels - Quantity: 125")]
    public void DisplayProductionLabel_PrintsExpectedLabel(
        string productName,
        int quantity,
        string expected)
    {
        using StringWriter output = new();
        Console.SetOut(output);

        CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise03.MainClass
            .DisplayProductionLabel(productName, quantity);

        string actual = output.ToString().Trim();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Main_PrintsRequiredProductionLabel()
    {
        using StringWriter output = new();
        Console.SetOut(output);

        CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise03.MainClass
            .Main();

        string actual = output.ToString().Trim();

        Assert.Equal("Product: Bolts - Quantity: 75", actual);
    }
    [Theory]
    [InlineData("Machine A", 0, "Machine A: Inspection Passed")]
    [InlineData("Press 2", 1, "Press 2: Inspection Failed")]
    [InlineData("Cutter 7", 4, "Cutter 7: Inspection Failed")]
    [InlineData("Welder 3", 0, "Welder 3: Inspection Passed")]
    public void DisplayInspectionResult_PrintsExpectedResult(
        string machineName,
        int defectsFound,
        string expected)
    {
        using StringWriter output = new();
        Console.SetOut(output);

        CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise04.MainClass
            .DisplayInspectionResult(machineName, defectsFound);

        string actual = output.ToString().Trim();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Main_PrintsRequiredInspectionResult()
    {
        using StringWriter output = new();
        Console.SetOut(output);

        CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise04.MainClass
            .Main();

        string actual = output.ToString().Trim();

        Assert.Equal("Press 4: Inspection Passed", actual);
    }
    [Theory]
    [InlineData("Taylor", 6, 42.50, "Customer: Taylor\r\nItems: 6\r\nTotal: $42.50")]
    [InlineData("Jordan", 1, 5.00, "Customer: Jordan\r\nItems: 1\r\nTotal: $5.00")]
    [InlineData("Casey", 20, 100.50, "Customer: Casey\r\nItems: 20\r\nTotal: $100.50")]
    [InlineData("Riley", 0, 0.00, "Customer: Riley\r\nItems: 0\r\nTotal: $0.00")]
    public void DisplayOrderSummary_PrintsExpectedSummary(
        string customerName,
        int itemCount,
        double totalCost,
        string expected)
    {
        using StringWriter output = new();
        Console.SetOut(output);

        CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise05.MainClass
            .DisplayOrderSummary(
                customerName,
                itemCount,
                (decimal)totalCost);

        string actual = output.ToString().Trim();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Main_PrintsRequiredOrderSummary()
    {
        using StringWriter output = new();
        Console.SetOut(output);

        CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise05.MainClass
            .Main();

        string actual = output.ToString().Trim();

        string expected =
            "Customer: Morgan\r\n" +
            "Items: 12\r\n" +
            "Total: $84.75";

        Assert.Equal(expected, actual);
    }



}