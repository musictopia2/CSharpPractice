namespace CSharpPracticeTests.Section05Loops.Lesson02DoWhileLoops;
[Trait("Section", "Section05Loops")]
public class ExercisesClass
{
    [Fact]
    public void Exercise01_DisplayProductionChecks_DisplaysThreeChecks()
    {
        StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section05Loops.Lesson02DoWhileLoops.Exercise01.MainClass.DisplayProductionChecks();

        string expected =
            "=== PRODUCTION CHECK ===\r\n" +
            "Machine Status: Running\r\n" +
            "Safety Check: Passed\r\n" +
            "Check Number: 1\r\n" +
            "=== PRODUCTION CHECK ===\r\n" +
            "Machine Status: Running\r\n" +
            "Safety Check: Passed\r\n" +
            "Check Number: 2\r\n" +
            "=== PRODUCTION CHECK ===\r\n" +
            "Machine Status: Running\r\n" +
            "Safety Check: Passed\r\n" +
            "Check Number: 3\r\n";

        Assert.Equal(expected, writer.ToString());
    }
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(4, 4)]
    [InlineData(7, 7)]
    [InlineData(15, 15)]
    public void Exercise02_ProcessShippingLabels_ReturnsProcessedCount(
        int labelCount,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson02DoWhileLoops.Exercise02.MainClass
                .ProcessShippingLabels(labelCount);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(8, 10, 1)]
    [InlineData(5, 11, 3)]
    [InlineData(10, 17, 4)]
    [InlineData(1, 2, 1)]
    [InlineData(20, 30, 5)]
    public void Exercise03_CountInspectionAttempts_ReturnsNumberOfAttempts(
        int startingScore,
        int requiredScore,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson02DoWhileLoops.Exercise03.MainClass
                .CountInspectionAttempts(startingScore, requiredScore);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, 5, 15, 1)]
    [InlineData(4, 3, 12, 3)]
    [InlineData(20, 5, 15, 1)]
    [InlineData(1, 4, 17, 4)]
    [InlineData(5, 10, 6, 1)]
    [InlineData(2, 3, 14, 4)]
    public void Exercise04_CalculateProductionRuns_ReturnsNumberOfRuns(
        int currentUnits,
        int unitsPerRun,
        int targetUnits,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson02DoWhileLoops.Exercise04.MainClass
                .CalculateProductionRuns(
                    currentUnits,
                    unitsPerRun,
                    targetUnits);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, 5, 15)]
    [InlineData(11, 4, 12)]
    [InlineData(20, 6, 24)]
    [InlineData(7, 2, 8)]
    [InlineData(1, 10, 10)]
    [InlineData(24, 8, 32)]
    public void Exercise05_FindNextPackageSize_ReturnsFirstLargerValidSize(
       int startingSize,
       int packageMultiple,
       int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson02DoWhileLoops.Exercise05.MainClass
                .FindNextPackageSize(
                    startingSize,
                    packageMultiple);

        Assert.Equal(expected, actual);
    }
}