namespace CSharpPracticeTests.Section05Loops.Lesson07Review;
[Trait("Section", "Section05Loops")]
public class ExercisesClass
{
    [Theory]
    [InlineData(new int[] { 10, 12, 0, 25, 7, 30 }, 3)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 0)]
    [InlineData(new int[] { 0, 0, 15 }, 1)]
    [InlineData(new int[] { 5, 10, 15, 20 }, 4)]
    [InlineData(new int[] { 0, 0, 0 }, 0)]
    [InlineData(new int[] { 11 }, 0)]
    [InlineData(new int[] { 25 }, 1)]
    public void CountAcceptedShipments_ReturnsExpectedCount(
        int[] shipmentSizes,
        int expected)
    {
        List<int> shipments = shipmentSizes.ToList();

        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson07Review.Exercise01
                .MainClass.CountAcceptedShipments(shipments);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(20, 10, 50, 3)]
    [InlineData(45, 10, 50, 1)]
    [InlineData(50, 10, 50, 0)]
    [InlineData(70, 10, 50, 0)]
    [InlineData(0, 25, 100, 4)]
    [InlineData(99, 1, 100, 1)]
    public void CountProductionRuns_ReturnsExpectedRuns(
        int startingUnits,
        int unitsPerRun,
        int targetUnits,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson07Review.Exercise02
                .MainClass.CountProductionRuns(
                    startingUnits,
                    unitsPerRun,
                    targetUnits);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(3, 4, 12)]
    [InlineData(5, 2, 10)]
    [InlineData(1, 6, 6)]
    [InlineData(4, 1, 4)]
    [InlineData(2, 3, 6)]
    [InlineData(6, 5, 30)]
    public void CountRequiredInspections_ReturnsExpectedCount(
        int numberOfMachines,
        int inspectionsPerMachine,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson07Review.Exercise03
                .MainClass.CountRequiredInspections(
                    numberOfMachines,
                    inspectionsPerMachine);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(2, 4, 6)]
    [InlineData(1, 6, 4)]
    [InlineData(3, 2, 6)]
    [InlineData(4, 3, 8)]
    [InlineData(2, 6, 8)]
    [InlineData(5, 1, 5)]
    [InlineData(3, 5, 12)]
    public void CountActivePositions_ReturnsExpectedCount(
        int numberOfAisles,
        int positionsPerAisle,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson07Review.Exercise04
                .MainClass.CountActivePositions(
                    numberOfAisles,
                    positionsPerAisle);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(new int[] { 6, 0, 3 }, 8)]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 5 }, 4)]
    [InlineData(new int[] { 10 }, 8)]
    [InlineData(new int[] { 4, 4 }, 8)]
    [InlineData(new int[] { 5, 5 }, 8)]
    [InlineData(new int[] { 0, 0, 0 }, 0)]
    [InlineData(new int[] { 11, 3, 5 }, 16)]
    public void CountPackagesForDelivery_ReturnsExpectedCount(
        int[] packagesPerBatch,
        int expected)
    {
        List<int> batches = packagesPerBatch.ToList();

        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson07Review.Exercise05
                .MainClass.CountPackagesForDelivery(batches);

        Assert.Equal(expected, actual);
    }
}