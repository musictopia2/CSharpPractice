namespace CSharpPracticeTests.Section03Operators.Lesson03Multiplication;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Theory]
    [InlineData(6, 8, 48)]
    [InlineData(0, 12, 0)]
    [InlineData(9, 1, 9)]
    [InlineData(5, -4, -20)]
    [InlineData(-3, -7, 21)]
    public void Exercise01CalculateSupplyTotal(int quantity, int amountPerItem, int expected)
    {
        int actual = CSharpPracticeLibrary.Section03Operators.Lesson03Multiplication.Exercise01.MainClass.CalculateSupplyTotal(
            quantity,
            amountPerItem);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(7, 15, 105)]
    [InlineData(4, 25, 100)]
    [InlineData(1, 18, 18)]
    [InlineData(9, 0, 0)]
    [InlineData(12, 3, 36)]
    public void Exercise02CalculateProductionOutput(int machines, int itemsPerMachine, int expected)
    {
        int actual = CSharpPracticeLibrary.Section03Operators.Lesson03Multiplication.Exercise02.MainClass.CalculateProductionOutput(
            machines,
            itemsPerMachine);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(12, 9, 108)]
    [InlineData(5, 20, 100)]
    [InlineData(1, 14, 14)]
    [InlineData(0, 16, 0)]
    [InlineData(11, 0, 0)]
    public void Exercise03CalculateTileCount(int rows, int tilesPerRow, int expected)
    {
        int actual = CSharpPracticeLibrary.Section03Operators.Lesson03Multiplication.Exercise03.MainClass.CalculateTileCount(
            rows,
            tilesPerRow);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(4, 6, 10, 240)]
    [InlineData(2, 5, 8, 80)]
    [InlineData(1, 12, 15, 180)]
    [InlineData(0, 7, 9, 0)]
    [InlineData(3, 0, 11, 0)]
    public void Exercise04CalculateTotalSeats(
    int sections,
    int rowsPerSection,
    int seatsPerRow,
    int expected)
    {
        int actual = CSharpPracticeLibrary.Section03Operators.Lesson03Multiplication.Exercise04.MainClass.CalculateTotalSeats(
            sections,
            rowsPerSection,
            seatsPerRow);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5, 8, 3, 120)]
    [InlineData(4, 10, 2, 80)]
    [InlineData(1, 12, 5, 60)]
    [InlineData(0, 8, 4, 0)]
    [InlineData(6, 0, 3, 0)]
    [InlineData(7, 5, 0, 0)]
    public void Exercise05CalculateShipmentWeight(
    int cartonCount,
    int unitsPerCarton,
    int weightPerUnit,
    int expected)
    {
        int actual = CSharpPracticeLibrary.Section03Operators.Lesson03Multiplication.Exercise05.MainClass.CalculateShipmentWeight(
            cartonCount,
            unitsPerCarton,
            weightPerUnit);

        Assert.Equal(expected, actual);
    }
}