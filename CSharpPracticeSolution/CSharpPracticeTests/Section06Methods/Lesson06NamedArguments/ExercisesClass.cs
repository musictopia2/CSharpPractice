namespace CSharpPracticeTests.Section06Methods.Lesson06NamedArguments;
[Trait("Section", "Section06Methods")]
public class ExercisesClass
{
    [Theory]
    [InlineData(1, "Destination: Phoenix, Packages: 3, Priority: False")]
    [InlineData(2, "Destination: Seattle, Packages: 6, Priority: True")]
    [InlineData(3, "Destination: Boston, Packages: 2, Priority: True")]
    [InlineData(4, "Destination: Dallas, Packages: 5, Priority: False")]
    [InlineData(0, "Invalid scenario")]
    [InlineData(5, "Invalid scenario")]
    [InlineData(-1, "Invalid scenario")]
    public void Exercise01_CallWithNamedArguments_ReturnsExpectedResult(
        int scenario,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson06NamedArguments.Exercise01
                .MainClass.CallWithNamedArguments(scenario);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(1, "Customer: Jordan, Hour: 10, Confirmed: False")]
    [InlineData(2, "Customer: Morgan, Hour: 2, Confirmed: True")]
    [InlineData(3, "Customer: Casey, Hour: 4, Confirmed: False")]
    [InlineData(4, "Customer: Riley, Hour: 7, Confirmed: True")]
    [InlineData(0, "Invalid scenario")]
    [InlineData(5, "Invalid scenario")]
    [InlineData(-1, "Invalid scenario")]
    public void CallAppointment_ReturnsExpectedResult(
        int scenario,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson06NamedArguments.Exercise02
                .MainClass.CallAppointment(scenario);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(1, "Machine: Press, Inspections: 4, Needs Repair: False")]
    [InlineData(2, "Machine: Welder, Inspections: 7, Needs Repair: True")]
    [InlineData(3, "Machine: Drill, Inspections: 2, Needs Repair: False")]
    [InlineData(4, "Machine: Lathe, Inspections: 6, Needs Repair: True")]
    [InlineData(0, "Invalid scenario")]
    [InlineData(5, "Invalid scenario")]
    [InlineData(-1, "Invalid scenario")]
    public void GetMachineReport_ReturnsExpectedResult(
        int scenario,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson06NamedArguments.Exercise03
                .MainClass.GetMachineReport(scenario);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(4, 15, 8, 12, 80)]
    [InlineData(3, 20, 5, 10, 75)]
    [InlineData(10, 7, 4, 6, 80)]
    [InlineData(1, 25, 0, 5, 30)]
    [InlineData(0, 50, 10, 3, 13)]
    public void CalculateRushSupplyCost_ReturnsExpectedResult(
       int quantity,
       int costPerItem,
       int deliveryFee,
       int rushFee,
       int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson06NamedArguments.Exercise04
                .MainClass.CalculateRushSupplyCost(
                    quantity,
                    costPerItem,
                    deliveryFee,
                    rushFee);

        Assert.Equal(expected, actual);
    }
    [Fact]
    public void PrepareStorageRequest_ReturnsExpectedRequest()
    {
        string expected =
            "Product: Monitors, Bin: 24, Quantity: 8, Fragile: True";

        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson06NamedArguments.Exercise05
                .MainClass.PrepareStorageRequest();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Glassware", 12, 6, true,
        "Product: Glassware, Bin: 12, Quantity: 6, Fragile: True")]
    [InlineData("Books", 5, 20, false,
        "Product: Books, Bin: 5, Quantity: 20, Fragile: False")]
    [InlineData("Lamps", 31, 3, true,
        "Product: Lamps, Bin: 31, Quantity: 3, Fragile: True")]
    public void CreateStorageRequest_ReturnsExpectedRequest(
        string productName,
        int binNumber,
        int quantity,
        bool fragile,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson06NamedArguments.Exercise05
                .MainClass.CreateStorageRequest(
                    productName,
                    binNumber,
                    quantity,
                    fragile);

        Assert.Equal(expected, actual);
    }
}