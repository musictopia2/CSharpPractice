
namespace CSharpPracticeTests.Section06Methods.Lesson11InParameters;
[Trait("Section", "Section06Methods")]
public class ExercisesClass
{
    [Theory]
    [InlineData(12.50, 4, 50.00)]
    [InlineData(8.25, 3, 24.75)]
    [InlineData(100.00, 1, 100.00)]
    [InlineData(5.75, 0, 0.00)]
    [InlineData(2.40, 10, 24.00)]
    public void CalculateShipmentValue_ReturnsExpectedValue(
        decimal itemPrice,
        int quantity,
        decimal expected)
    {
        CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise01.Shipment shipment = new()
        {
            ItemPrice = itemPrice,
            Quantity = quantity
        };

        decimal actual = CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise01.MainClass.CalculateShipmentValue(in shipment);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(6, 2.5, 15.0)]
    [InlineData(4, 3.75, 15.0)]
    [InlineData(1, 8.5, 8.5)]
    [InlineData(0, 4.25, 0.0)]
    [InlineData(10, 1.2, 12.0)]
    public void CalculateTotalWeight_ReturnsExpectedValue(
        int units,
        double weightPerUnit,
        double expected)
    {
        CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise02.InventoryStock stock = new()
        {
            Units = units,
            WeightPerUnit = weightPerUnit
        };

        double actual =
            CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise02.MainClass
                .CalculateTotalWeight(in stock);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(8.0, 5.0, 40.0)]
    [InlineData(3.5, 2.0, 7.0)]
    [InlineData(1.0, 1.0, 1.0)]
    [InlineData(0.0, 5.0, 0.0)]
    [InlineData(8.0, 0.0, 0.0)]
    [InlineData(-2.0, 5.0, 0.0)]
    [InlineData(8.0, -3.0, 0.0)]
    public void CalculateArea_ReturnsExpectedValue(
       double width,
       double height,
       double expected)
    {
        CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise03.RectangleMeasurements measurements = new()
        {
            Width = width,
            Height = height
        };

        double actual =
            CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise03.MainClass
                .CalculateArea(in measurements);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(120, 8, 112)]
    [InlineData(50, 0, 50)]
    [InlineData(25, 5, 20)]
    [InlineData(10, 10, 0)]
    public void CalculateUsableUnits_ReturnsExpectedValue(
        int unitsProduced,
        int defectiveUnits,
        int expected)
    {
        CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise04.ProductionData production = new()
        {
            UnitsProduced = unitsProduced,
            DefectiveUnits = defectiveUnits
        };

        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise04.MainClass
                .CalculateUsableUnits(in production);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(120, 8, 110, true)]
    [InlineData(120, 8, 112, true)]
    [InlineData(120, 8, 113, false)]
    [InlineData(50, 0, 50, true)]
    [InlineData(25, 5, 25, false)]
    public void MeetsTarget_ReturnsExpectedValue(
        int unitsProduced,
        int defectiveUnits,
        int target,
        bool expected)
    {
        CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise04.ProductionData production = new()
        {
            UnitsProduced = unitsProduced,
            DefectiveUnits = defectiveUnits
        };

        bool actual =
            CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise04.MainClass
                .MeetsTarget(in production, target);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, 4.5, 5.0, 50.0, true)]
    [InlineData(10, 4.5, 5.0, 49.9, false)]
    [InlineData(5, 10.0, 8.0, 60.0, true)]
    [InlineData(5, 10.0, 8.0, 58.0, true)]
    [InlineData(5, 10.0, 8.0, 57.9, false)]
    [InlineData(0, 10.0, 8.0, 8.0, true)]
    public void CanLoadShipment_ReturnsExpectedValue(
       int packageCount,
       double weightPerPackage,
       double containerWeight,
       double maximumWeight,
       bool expected)
    {
        CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise05.ShipmentLoad shipment = new()
        {
            PackageCount = packageCount,
            WeightPerPackage = weightPerPackage,
            ContainerWeight = containerWeight
        };

        bool actual =
            CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise05.MainClass
                .CanLoadShipment(in shipment, maximumWeight);

        Assert.Equal(expected, actual);
    }
}