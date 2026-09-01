namespace CSharpPracticeTests.Section05Loops.Lesson04ForEachLoops;
[Trait("Section", "Section05Loops")]
public class ExercisesClass
{
    [Fact]
    public void PrintInspectionAreas_PrintsEachAreaOnSeparateLine()
    {
        // Arrange
        string[] areas =
        {
            "Loading Dock",
            "Assembly Floor",
            "Storage Room",
            "Shipping Bay"
        };

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section05Loops.Lesson04ForEachLoops.Exercise01
            .MainClass.PrintInspectionAreas(areas);

        // Assert
        string expected =
            $"Loading Dock{Environment.NewLine}" +
            $"Assembly Floor{Environment.NewLine}" +
            $"Storage Room{Environment.NewLine}" +
            $"Shipping Bay{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintInspectionAreas_WithOneArea_PrintsOneLine()
    {
        // Arrange
        string[] areas =
        {
            "Quality Control"
        };

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section05Loops.Lesson04ForEachLoops.Exercise01
            .MainClass.PrintInspectionAreas(areas);

        // Assert
        string expected = $"Quality Control{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintInspectionAreas_WithEmptyArray_PrintsNothing()
    {
        // Arrange
        string[] areas = [];

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section05Loops.Lesson04ForEachLoops.Exercise01
            .MainClass.PrintInspectionAreas(areas);

        // Assert
        Assert.Equal(string.Empty, writer.ToString());
    }
    [Theory]
    [InlineData(new bool[] { true, false, true, true }, 3)]
    [InlineData(new bool[] { false, false, false }, 0)]
    [InlineData(new bool[] { true, true, true, true }, 4)]
    [InlineData(new bool[] { true }, 1)]
    [InlineData(new bool[] { false }, 0)]
    [InlineData(new bool[] { }, 0)]
    public void CountCompletedInspections_ReturnsCorrectCount(
        bool[] inspections,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson04ForEachLoops.Exercise02
            .MainClass.CountCompletedInspections(inspections);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(new int[] { 12, 8, 15 }, 35)]
    [InlineData(new int[] { 5, 5, 5, 5 }, 20)]
    [InlineData(new int[] { 25 }, 25)]
    [InlineData(new int[] { 0, 10, 0, 20 }, 30)]
    [InlineData(new int[] { }, 0)]
    public void CalculateTotalPackages_ReturnsCorrectTotal(
        int[] dailyPackages,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson04ForEachLoops.Exercise03
            .MainClass.CalculateTotalPackages(dailyPackages);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(new int[] { 12, 20, 35, 8, 24 }, 3)]
    [InlineData(new int[] { 20, 20, 20 }, 3)]
    [InlineData(new int[] { 19, 5, 12 }, 0)]
    [InlineData(new int[] { 50 }, 1)]
    [InlineData(new int[] { 19 }, 0)]
    [InlineData(new int[] { }, 0)]
    public void CountPriorityShipments_ReturnsCorrectCount(
        int[] packageCounts,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson04ForEachLoops.Exercise04
            .MainClass.CountPriorityShipments(packageCounts);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(new int[] { 25, 7, 50, 91, 90, 3 }, 3)]
    [InlineData(new int[] { 10, 20, 50, 90 }, 0)]
    [InlineData(new int[] { 9, 91 }, 2)]
    [InlineData(new int[] { 1, 5, 95, 100 }, 4)]
    [InlineData(new int[] { 10 }, 0)]
    [InlineData(new int[] { 90 }, 0)]
    [InlineData(new int[] { }, 0)]
    public void CountFlaggedReadings_ReturnsCorrectCount(
        int[] readings,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson04ForEachLoops.Exercise05
            .MainClass.CountFlaggedReadings(readings);

        Assert.Equal(expected, actual);
    }
}