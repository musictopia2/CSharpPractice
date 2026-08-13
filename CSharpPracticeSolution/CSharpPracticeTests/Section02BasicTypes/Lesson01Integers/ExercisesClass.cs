namespace CSharpPracticeTests.Section02BasicTypes.Lesson01Integers;
[Trait("Section", "Section02BasicTypes")]
public class ExercisesClass
{
    [Theory]
    [InlineData(100, 25, 75)]
    [InlineData(50, 20, 30)]
    [InlineData(10, 15, -5)]
    [InlineData(0, 0, 0)]
    public void GetRemainingPoints_ReturnsExpectedResult(
        int totalPoints,
        int usedPoints,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson01Integers.Exercise01.MainClass
                .GetRemainingPoints(totalPoints, usedPoints);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, 20, 10)]
    [InlineData(20, 5, -15)]
    [InlineData(-10, 5, 15)]
    [InlineData(-5, -15, -10)]
    [InlineData(0, 0, 0)]
    public void GetTemperatureChange_ReturnsExpectedResult(
        int startingTemperature,
        int endingTemperature,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson01Integers.Exercise02.MainClass
                .GetTemperatureChange(startingTemperature, endingTemperature);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5, 10, 50)]
    [InlineData(3, 7, 21)]
    [InlineData(1, 25, 25)]
    [InlineData(0, 100, 0)]
    [InlineData(12, 12, 144)]
    public void GetTotalItems_ReturnsExpectedResult(
        int numberOfBoxes,
        int itemsPerBox,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson01Integers.Exercise03.MainClass
                .GetTotalItems(numberOfBoxes, itemsPerBox);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(100, 50, 20, 130)]
    [InlineData(50, 10, 30, 30)]
    [InlineData(0, 25, 10, 15)]
    [InlineData(10, 5, 20, -5)]
    [InlineData(-10, 20, 5, 5)]
    public void GetScoreDifference_ReturnsExpectedResult(
        int startingScore,
        int pointsEarned,
        int pointsLost,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson01Integers.Exercise04.MainClass
                .GetScoreDifference(startingScore, pointsEarned, pointsLost);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(100, 50, 25, 125)]
    [InlineData(20, 10, 50, -20)]
    [InlineData(0, 0, 0, 0)]
    [InlineData(-20, 30, 5, 5)]
    public void GetNetBalance_ReturnsExpectedResult(
        int startingBalance,
        int moneyAdded,
        int moneySpent,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson01Integers.Exercise05.MainClass
                .GetNetBalance(startingBalance, moneyAdded, moneySpent);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(25, 50)]
    [InlineData(-10, -20)]
    [InlineData(0, 0)]
    [InlineData(100, 200)]
    public void GetDoubleBalance_ReturnsExpectedResult(
        int balance,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson01Integers.Exercise05.MainClass
                .GetDoubleBalance(balance);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetMinimumInteger_ReturnsIntMinValue()
    {
        int actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson01Integers.Exercise05.MainClass
                .GetMinimumInteger();

        Assert.Equal(int.MinValue, actual);
    }

    [Fact]
    public void GetMaximumInteger_ReturnsIntMaxValue()
    {
        int actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson01Integers.Exercise05.MainClass
                .GetMaximumInteger();

        Assert.Equal(int.MaxValue, actual);
    }


}