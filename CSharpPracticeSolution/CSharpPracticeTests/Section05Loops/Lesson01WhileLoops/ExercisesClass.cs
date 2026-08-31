namespace CSharpPracticeTests.Section05Loops.Lesson01WhileLoops;
[Trait("Section", "Section05Loops")]
public class ExercisesClass
{
    [Fact]
    public void PrintCheckpoints_PrintsNumbersThreeThroughSeven()
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section05Loops.Lesson01WhileLoops.Exercise01.MainClass.PrintCheckpoints();

        string expected =
            $"3{Environment.NewLine}" +
            $"4{Environment.NewLine}" +
            $"5{Environment.NewLine}" +
            $"6{Environment.NewLine}" +
            $"7{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintCountdown_PrintsEightThroughTwo()
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section05Loops.Lesson01WhileLoops.Exercise02.MainClass.PrintCountdown();

        string expected =
            $"8{Environment.NewLine}" +
            $"7{Environment.NewLine}" +
            $"6{Environment.NewLine}" +
            $"5{Environment.NewLine}" +
            $"4{Environment.NewLine}" +
            $"3{Environment.NewLine}" +
            $"2{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }
    [Theory]
    [InlineData(1, 10)]
    [InlineData(4, 10)]
    [InlineData(5, 11)]
    [InlineData(10, 10)]
    [InlineData(14, 14)]
    [InlineData(-2, 10)]
    public void IncreaseToTarget_ReturnsExpectedValue(int startingValue, int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson01WhileLoops.Exercise03.MainClass
                .IncreaseToTarget(startingValue);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, 5, 25, 3)]
    [InlineData(20, 4, 25, 2)]
    [InlineData(30, 5, 30, 0)]
    [InlineData(40, 5, 30, 0)]
    [InlineData(0, 6, 17, 3)]
    [InlineData(14, 2, 15, 1)]
    public void CalculateBoxesNeeded_ReturnsExpectedNumberOfBoxes(
        int currentItems,
        int itemsPerBox,
        int requiredItems,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson01WhileLoops.Exercise04.MainClass
                .CalculateBoxesNeeded(currentItems, itemsPerBox, requiredItems);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, 4, 2)]
    [InlineData(15, 5, 0)]
    [InlineData(7, 3, 2)]
    [InlineData(20, 6, 4)]
    [InlineData(1, 2, 1)]
    [InlineData(24, 8, 0)]
    public void CountAttemptsUntilDivisible_ReturnsExpectedNumberOfIncreases(
       int startingValue,
       int divisor,
       int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson01WhileLoops.Exercise05.MainClass
                .CountAttemptsUntilDivisible(startingValue, divisor);

        Assert.Equal(expected, actual);
    }
}