namespace CSharpPracticeTests.Section07Collections.Lesson02AccessingListContents;
[Trait("Section", "Section07Collections")]
public class ExercisesClass
{
    [Theory]
    [InlineData(new string[] { "Receiving", "Cold Storage", "Packing", "Shipping" },
        "Receiving\r\nShipping\r\n")]
    [InlineData(new string[] { "North", "South" },
        "North\r\nSouth\r\n")]
    [InlineData(new string[] { "Only Zone" },
        "Only Zone\r\nOnly Zone\r\n")]
    public void PrintFirstAndLastZone_PrintsExpectedZones(
        string[] zones,
        string expected)
    {
        List<string> zoneList = zones.ToList();

        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section07Collections.Lesson02AccessingListContents.Exercise01.MainClass
            .PrintFirstAndLastZone(zoneList);

        string actual = writer.ToString();

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(
         new string[] { "Received", "Reviewed", "Approved", "Completed" },
         "Reviewed\r\nApproved\r\n")]
    [InlineData(
         new string[] { "Queued", "Validated", "Processed", "Archived" },
         "Validated\r\nProcessed\r\n")]
    [InlineData(
         new string[] { "North", "East", "South", "West", "Central" },
         "East\r\nSouth\r\n")]
    public void PrintMiddleStages_PrintsItemsAtIndexesOneAndTwo(
         string[] stages,
         string expected)
    {
        List<string> stageList = stages.ToList();

        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section07Collections.Lesson02AccessingListContents.Exercise02.MainClass
            .PrintMiddleStages(stageList);

        string actual = writer.ToString();

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(
        new int[] { 18, 24, 31, 27, 40 },
        0,
        18)]
    [InlineData(
        new int[] { 18, 24, 31, 27, 40 },
        2,
        31)]
    [InlineData(
        new int[] { 18, 24, 31, 27, 40 },
        4,
        40)]
    [InlineData(
        new int[] { 5, 10, 15 },
        1,
        10)]
    public void GetSelectedReading_ReturnsValueAtRequestedIndex(
        int[] readings,
        int index,
        int expected)
    {
        List<int> readingList = readings.ToList();

        int actual =
            CSharpPracticeLibrary.Section07Collections.Lesson02AccessingListContents.Exercise03.MainClass
                .GetSelectedReading(readingList, index);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(
        new int[] { 40, 55, 30, 65 },
        3,
        "Selected is higher")]
    [InlineData(
        new int[] { 40, 55, 30, 65 },
        2,
        "Selected is lower")]
    [InlineData(
        new int[] { 40, 55, 40, 65 },
        2,
        "Same amount")]
    [InlineData(
        new int[] { 25, 10, 30 },
        0,
        "Same amount")]
    public void CompareFirstAndSelectedShipment_ReturnsExpectedResult(
        int[] shipments,
        int index,
        string expected)
    {
        List<int> shipmentList = shipments.ToList();

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson02AccessingListContents.Exercise04.MainClass
                .CompareFirstAndSelectedShipment(shipmentList, index);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(
        new int[] { 20, 30, 45, 25 },
        2,
        "Inspection package is heaviest")]
    [InlineData(
        new int[] { 20, 30, 10, 40 },
        2,
        "Inspection package is lightest")]
    [InlineData(
        new int[] { 20, 30, 25, 40 },
        2,
        "Inspection package is between")]
    [InlineData(
        new int[] { 50, 20, 35, 60 },
        2,
        "Inspection package is between")]
    [InlineData(
        new int[] { 25, 25, 25 },
        2,
        "Inspection package is between")]
    public void CreateLoadingCheck_ReturnsExpectedResult(
        int[] packageWeights,
        int inspectionIndex,
        string expected)
    {
        List<int> weightList = packageWeights.ToList();

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson02AccessingListContents.Exercise05.MainClass
                .CreateLoadingCheck(weightList, inspectionIndex);

        Assert.Equal(expected, actual);
    }
}