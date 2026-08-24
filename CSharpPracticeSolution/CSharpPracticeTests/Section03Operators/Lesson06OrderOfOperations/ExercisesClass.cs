namespace CSharpPracticeTests.Section03Operators.Lesson06OrderOfOperations;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Theory]
    [InlineData(4, 6, 3, 30)]
    [InlineData(10, 5, 2, 30)]
    [InlineData(0, 8, 5, 40)]
    [InlineData(7, 3, 4, 40)]
    [InlineData(2, 1, 10, 30)]
    public void Exercise01(
       int firstGroup,
       int secondGroup,
       int costPerItem,
       int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson06OrderOfOperations.Exercise01.MainClass
                .CalculateTotalCost(firstGroup, secondGroup, costPerItem);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(4, 5, 24)]
    [InlineData(3, 10, 33)]
    [InlineData(8, 2, 24)]
    [InlineData(1, 7, 8)]
    [InlineData(10, 0, 10)]
    public void Exercise02(
    int rows,
    int itemsPerRow,
    int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson06OrderOfOperations.Exercise02.MainClass
                .CalculateCapacity(rows, itemsPerRow);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(4, 20, 5, 60)]
    [InlineData(3, 12, 2, 30)]
    [InlineData(10, 8, 3, 50)]
    [InlineData(1, 15, 4, 11)]
    [InlineData(6, 10, 0, 60)]
    public void Exercise03(
    int sections,
    int ticketsPerSection,
    int unavailablePerSection,
    int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson06OrderOfOperations.Exercise03.MainClass
                .CalculateAvailableTickets(
                    sections,
                    ticketsPerSection,
                    unavailablePerSection);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5, 2, 10, 15, 55)]
    [InlineData(8, 4, 5, 10, 50)]
    [InlineData(3, 1, 25, 20, 80)]
    [InlineData(0, 5, 10, 10, 40)]
    [InlineData(6, 4, 3, 30, 0)]
    public void Exercise04(
    int regularObjectives,
    int bonusObjectives,
    int pointsPerObjective,
    int penalty,
    int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson06OrderOfOperations.Exercise04.MainClass
                .CalculateScore(
                    regularObjectives,
                    bonusObjectives,
                    pointsPerObjective,
                    penalty);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, 8, 4, 3, 102)]
    [InlineData(12, 5, 5, 2, 80)]
    [InlineData(6, 6, 2, 4, 54)]
    [InlineData(1, 1, 1, 1, 12)]
    [InlineData(20, 10, 0, 0, 210)]
    public void Exercise05(
    int mainLength,
    int mainWidth,
    int extraLength,
    int extraWidth,
    int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson06OrderOfOperations.Exercise05.MainClass
                .CalculateFlooringNeeded(
                    mainLength,
                    mainWidth,
                    extraLength,
                    extraWidth);

        Assert.Equal(expected, actual);
    }
}