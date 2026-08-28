namespace CSharpPracticeTests.Section04ControlFlow.Lesson02IfElseStatements;
[Trait("Section", "Section04ControlFlow")]
public class ExercisesClass
{
    [Theory]
    [InlineData(100, 100, "Ready")]
    [InlineData(125, 100, "Ready")]
    [InlineData(75, 100, "Not Ready")]
    [InlineData(0, 1, "Not Ready")]
    [InlineData(1, 0, "Ready")]
    public void PrintCapacityStatus_PrintsExpectedResult(
        int currentAmount,
        int requiredAmount,
        string expected)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section04ControlFlow
            .Lesson02IfElseStatements.Exercise01.MainClass
            .PrintCapacityStatus(currentAmount, requiredAmount);

        string actual = writer.ToString().Trim();

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(40, 50, "Accepted")]
    [InlineData(50, 50, "Accepted")]
    [InlineData(60, 50, "Too Heavy")]
    [InlineData(1, 10, "Accepted")]
    [InlineData(11, 10, "Too Heavy")]
    public void PrintWeightStatus_PrintsExpectedResult(
        int packageWeight,
        int maximumWeight,
        string expected)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section04ControlFlow
            .Lesson02IfElseStatements.Exercise02.MainClass
            .PrintWeightStatus(packageWeight, maximumWeight);

        string actual = writer.ToString().Trim();

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(24, 6, "Full Cases")]
    [InlineData(25, 6, "Items Left Over")]
    [InlineData(30, 5, "Full Cases")]
    [InlineData(17, 4, "Items Left Over")]
    [InlineData(100, 10, "Full Cases")]
    public void PrintPackingStatus_PrintsExpectedResult(
        int itemCount,
        int itemsPerCase,
        string expected)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section04ControlFlow
            .Lesson02IfElseStatements.Exercise03.MainClass
            .PrintPackingStatus(itemCount, itemsPerCase);

        string actual = writer.ToString().Trim();

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(100, 100, 2, 3, "Bonus Earned")]
    [InlineData(120, 100, 3, 3, "Bonus Earned")]
    [InlineData(90, 100, 1, 3, "No Bonus")]
    [InlineData(120, 100, 4, 3, "No Bonus")]
    [InlineData(99, 100, 4, 3, "No Bonus")]
    public void PrintBonusStatus_PrintsExpectedResult(
        int points,
        int requiredPoints,
        int mistakes,
        int maximumMistakes,
        string expected)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section04ControlFlow
            .Lesson02IfElseStatements.Exercise04.MainClass
            .PrintBonusStatus(
                points,
                requiredPoints,
                mistakes,
                maximumMistakes);

        string actual = writer.ToString().Trim();

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(8, 7, false, "Late Fee Required")]
    [InlineData(8, 7, true, "No Late Fee")]
    [InlineData(7, 7, false, "No Late Fee")]
    [InlineData(6, 7, false, "No Late Fee")]
    [InlineData(10, 5, false, "Late Fee Required")]
    [InlineData(10, 5, true, "No Late Fee")]
    public void PrintLateFeeStatus_PrintsExpectedResult(
        int daysKept,
        int allowedDays,
        bool hasExtension,
        string expected)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section04ControlFlow
            .Lesson02IfElseStatements.Exercise05.MainClass
            .PrintLateFeeStatus(
                daysKept,
                allowedDays,
                hasExtension);

        string actual = writer.ToString().Trim();

        Assert.Equal(expected, actual);
    }
}