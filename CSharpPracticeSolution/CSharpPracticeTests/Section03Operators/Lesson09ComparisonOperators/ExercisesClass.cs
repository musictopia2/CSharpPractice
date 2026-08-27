namespace CSharpPracticeTests.Section03Operators.Lesson09ComparisonOperators;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Theory]
    [InlineData(5, 5, true)]
    [InlineData(5, 3, false)]
    [InlineData(0, 0, true)]
    [InlineData(-4, -4, true)]
    [InlineData(-4, 4, false)]
    public void ScoresMatch_ReturnsExpectedResult(
        int firstScore,
        int secondScore,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise01.MainClass
            .ScoresMatch(firstScore, secondScore);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 3, true)]
    [InlineData(5, 5, false)]
    [InlineData(0, 0, false)]
    [InlineData(-4, 4, true)]
    [InlineData(-4, -4, false)]
    public void ScoresDiffer_ReturnsExpectedResult(
        int firstScore,
        int secondScore,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise01.MainClass
            .ScoresDiffer(firstScore, secondScore);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(10, 5, true)]
    [InlineData(5, 10, false)]
    [InlineData(5, 5, false)]
    [InlineData(0, -1, true)]
    [InlineData(-10, -5, false)]
    public void FirstScoreIsHigher_ReturnsExpectedResult(
        int firstScore,
        int secondScore,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise01.MainClass
            .FirstScoreIsHigher(firstScore, secondScore);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(3, 7, true)]
    [InlineData(7, 3, false)]
    [InlineData(5, 5, false)]
    [InlineData(-5, 0, true)]
    [InlineData(-3, -8, false)]
    public void FirstScoreIsLower_ReturnsExpectedResult(
        int firstScore,
        int secondScore,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise01.MainClass
            .FirstScoreIsLower(firstScore, secondScore);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(8, 5, true)]
    [InlineData(5, 5, true)]
    [InlineData(4, 5, false)]
    [InlineData(0, 0, true)]
    [InlineData(-3, -5, true)]
    public void FirstScoreIsAtLeast_ReturnsExpectedResult(
        int firstScore,
        int secondScore,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise01.MainClass
            .FirstScoreIsAtLeast(firstScore, secondScore);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(4, 9, true)]
    [InlineData(5, 5, true)]
    [InlineData(10, 5, false)]
    [InlineData(0, 0, true)]
    [InlineData(-8, -3, true)]
    public void FirstScoreIsAtMost_ReturnsExpectedResult(
        int firstScore,
        int secondScore,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise01.MainClass
            .FirstScoreIsAtMost(firstScore, secondScore);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(32, true)]
    [InlineData(20, true)]
    [InlineData(0, true)]
    [InlineData(-10, true)]
    [InlineData(33, false)]
    [InlineData(75, false)]
    public void IsFreezing_ReturnsExpectedResult(
    int temperature,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise02.MainClass
            .IsFreezing(temperature);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(33, true)]
    [InlineData(50, true)]
    [InlineData(100, true)]
    [InlineData(32, false)]
    [InlineData(31, false)]
    [InlineData(-5, false)]
    public void IsAboveFreezing_ReturnsExpectedResult(
        int temperature,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise02.MainClass
            .IsAboveFreezing(temperature);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(70, 80, true)]
    [InlineData(80, 80, true)]
    [InlineData(81, 80, false)]
    [InlineData(0, 0, true)]
    [InlineData(-10, -5, true)]
    [InlineData(-4, -5, false)]
    public void IsWithinMaximum_ReturnsExpectedResult(
        int temperature,
        int maximumTemperature,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise02.MainClass
            .IsWithinMaximum(temperature, maximumTemperature);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(70, 75, true)]
    [InlineData(75, 70, true)]
    [InlineData(70, 70, false)]
    [InlineData(0, 0, false)]
    [InlineData(-5, 5, true)]
    [InlineData(-5, -5, false)]
    public void HasTemperatureChanged_ReturnsExpectedResult(
        int previousTemperature,
        int currentTemperature,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise02.MainClass
            .HasTemperatureChanged(previousTemperature, currentTemperature);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(100, 50, true)]
    [InlineData(50, 50, true)]
    [InlineData(49, 50, false)]
    [InlineData(0, 0, true)]
    [InlineData(5, 10, false)]
    public void HasEnoughSpace_ReturnsExpectedResult(
    int availableSpace,
    int requiredSpace,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise03.MainClass
            .HasEnoughSpace(availableSpace, requiredSpace);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(101, 100, true)]
    [InlineData(150, 100, true)]
    [InlineData(100, 100, false)]
    [InlineData(99, 100, false)]
    [InlineData(0, 0, false)]
    public void IsOverCapacity_ReturnsExpectedResult(
        int usedSpace,
        int capacity,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise03.MainClass
            .IsOverCapacity(usedSpace, capacity);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(100, 100, true)]
    [InlineData(0, 0, true)]
    [InlineData(75, 75, true)]
    [InlineData(100, 99, false)]
    [InlineData(99, 100, false)]
    public void HasExactUsage_ReturnsExpectedResult(
        int usedSpace,
        int expectedUsage,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise03.MainClass
            .HasExactUsage(usedSpace, expectedUsage);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(49, 50, true)]
    [InlineData(0, 10, true)]
    [InlineData(50, 50, false)]
    [InlineData(51, 50, false)]
    [InlineData(100, 50, false)]
    public void IsBelowMinimum_ReturnsExpectedResult(
        int availableSpace,
        int minimumSpace,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise03.MainClass
            .IsBelowMinimum(availableSpace, minimumSpace);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(10, 3, 5, 30, true)]
    [InlineData(10, 2, 5, 30, false)]
    [InlineData(10, 2, 10, 30, true)]
    [InlineData(25, 4, 20, 100, true)]
    [InlineData(5, 10, 0, 50, true)]
    [InlineData(5, 9, 0, 50, false)]
    public void MeetsMinimumOrder_ReturnsExpectedResult(
    int itemPrice,
    int quantity,
    int shippingCost,
    int minimumOrder,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise04.MainClass
            .MeetsMinimumOrder(
                itemPrice,
                quantity,
                shippingCost,
                minimumOrder);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, 5, 40, true)]
    [InlineData(10, 5, 50, true)]
    [InlineData(10, 5, 51, false)]
    [InlineData(25, 4, 100, true)]
    [InlineData(25, 4, 99, true)]
    [InlineData(25, 4, 101, false)]
    [InlineData(1, 1, 1, true)]
    public void CanShipOrder_ReturnsExpectedResult(
    int unitsPerBox,
    int numberOfBoxes,
    int unitsRequested,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise05.MainClass
            .CanShipOrder(
                unitsPerBox,
                numberOfBoxes,
                unitsRequested);

        Assert.Equal(expected, actual);
    }

}