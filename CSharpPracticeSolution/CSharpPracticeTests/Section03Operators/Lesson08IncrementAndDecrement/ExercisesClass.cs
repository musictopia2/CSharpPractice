namespace CSharpPracticeTests.Section03Operators.Lesson08IncrementAndDecrement;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Theory]
    [InlineData(5, 5)]
    [InlineData(0, 0)]
    [InlineData(-8, -8)]
    [InlineData(100, 100)]
    public void GetOriginalThenIncrease_ReturnsOriginalValue(int number, int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson08IncrementAndDecrement.Exercise01.MainClass
                .GetOriginalThenIncrease(number);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 6)]
    [InlineData(0, 1)]
    [InlineData(-8, -7)]
    [InlineData(100, 101)]
    public void IncreaseThenGet_ReturnsIncrementedValue(int number, int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson08IncrementAndDecrement.Exercise01.MainClass
                .IncreaseThenGet(number);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 5)]
    [InlineData(0, 0)]
    [InlineData(-8, -8)]
    [InlineData(100, 100)]
    public void GetOriginalThenDecrease_ReturnsOriginalValue(int number, int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson08IncrementAndDecrement.Exercise01.MainClass
                .GetOriginalThenDecrease(number);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 4)]
    [InlineData(0, -1)]
    [InlineData(-8, -9)]
    [InlineData(100, 99)]
    public void DecreaseThenGet_ReturnsDecrementedValue(int number, int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson08IncrementAndDecrement.Exercise01.MainClass
                .DecreaseThenGet(number);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(1, 2)]
    [InlineData(10, 11)]
    [InlineData(99, 100)]
    [InlineData(0, 1)]
    [InlineData(-5, -4)]
    public void Exercise02LevelUpReturnsNewLevel(int currentLevel, int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson08IncrementAndDecrement.Exercise02.MainClass
                .LevelUp(currentLevel);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(100, 100)]
    [InlineData(250, 250)]
    [InlineData(999, 999)]
    [InlineData(0, 0)]
    [InlineData(-10, -10)]
    public void Exercise03IssueTicketReturnsCurrentTicketNumber(
        int nextTicketNumber,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson08IncrementAndDecrement.Exercise03.MainClass
                .IssueTicket(nextTicketNumber);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(4, 10, 50)]
    [InlineData(9, 5, 50)]
    [InlineData(0, 25, 25)]
    [InlineData(10, 3, 33)]
    [InlineData(99, 2, 200)]
    public void Exercise04CalculateNextLevelPointsReturnsCorrectPoints(
        int currentLevel,
        int pointsPerLevel,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson08IncrementAndDecrement.Exercise04.MainClass
                .CalculateNextLevelPoints(currentLevel, pointsPerLevel);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(500, 500)]
    [InlineData(1200, 1200)]
    [InlineData(1, 1)]
    [InlineData(0, 0)]
    [InlineData(-25, -25)]
    public void Exercise05AssignPackageNumberReturnsCurrentNumber(
        int nextPackageNumber,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson08IncrementAndDecrement.Exercise05.MainClass
                .AssignPackageNumber(nextPackageNumber);

        Assert.Equal(expected, actual);
    }

}