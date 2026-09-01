namespace CSharpPracticeTests.Section05Loops.Lesson03ForLoops;
[Trait("Section", "Section05Loops")]
public class ExercisesClass
{
    [Fact]
    public void DisplayInspectionStations_ShouldDisplayStations1Through8()
    {
        // Arrange
        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section05Loops.Lesson03ForLoops.Exercise01.MainClass.DisplayInspectionStations();

        // Assert
        string expected =
            $"Inspection Station: 1{Environment.NewLine}" +
            $"Inspection Station: 2{Environment.NewLine}" +
            $"Inspection Station: 3{Environment.NewLine}" +
            $"Inspection Station: 4{Environment.NewLine}" +
            $"Inspection Station: 5{Environment.NewLine}" +
            $"Inspection Station: 6{Environment.NewLine}" +
            $"Inspection Station: 7{Environment.NewLine}" +
            $"Inspection Station: 8{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void DisplayStartupCountdown_ShouldCountDownAndStartMachine()
    {
        // Arrange
        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section05Loops.Lesson03ForLoops.Exercise02.MainClass.DisplayStartupCountdown();

        // Assert
        string expected =
            $"6{Environment.NewLine}" +
            $"5{Environment.NewLine}" +
            $"4{Environment.NewLine}" +
            $"3{Environment.NewLine}" +
            $"2{Environment.NewLine}" +
            $"1{Environment.NewLine}" +
            $"Machine Started{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void DisplayPackagesForSpecialCheck_ShouldDisplayEveryThirdPackage()
    {
        // Arrange
        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section05Loops.Lesson03ForLoops.Exercise03.MainClass.DisplayPackagesForSpecialCheck();

        // Assert
        string expected =
            $"Package 3{Environment.NewLine}" +
            $"Package 6{Environment.NewLine}" +
            $"Package 9{Environment.NewLine}" +
            $"Package 12{Environment.NewLine}" +
            $"Package 15{Environment.NewLine}" +
            $"Package 18{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0)]
    [InlineData(3, 0)]
    [InlineData(4, 1)]
    [InlineData(10, 2)]
    [InlineData(17, 4)]
    [InlineData(20, 5)]
    public void CountQualityFailures_ShouldReturnCorrectFailureCount(
        int numberOfItems,
        int expected)
    {
        // Act
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson03ForLoops.Exercise04.MainClass
                .CountQualityFailures(numberOfItems);

        // Assert
        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(0, 5, 0)]
    [InlineData(4, 5, 0)]
    [InlineData(5, 5, 1)]
    [InlineData(20, 5, 4)]
    [InlineData(22, 5, 4)]
    [InlineData(30, 6, 5)]
    [InlineData(17, 3, 5)]
    public void CountMaintenanceCheckpoints_ShouldReturnCorrectCheckpointCount(
        int totalCycles,
        int checkpointInterval,
        int expected)
    {
        // Act
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson03ForLoops.Exercise05.MainClass
                .CountMaintenanceCheckpoints(totalCycles, checkpointInterval);

        // Assert
        Assert.Equal(expected, actual);
    }
}