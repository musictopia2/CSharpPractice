namespace CSharpPracticeTests.Section03Operators.Lesson05ModuloOperator;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Theory]
    [InlineData(23, 5, 3)]
    [InlineData(18, 6, 0)]
    [InlineData(9, 4, 1)]
    [InlineData(4, 10, 4)]
    [InlineData(31, 7, 3)]
    [InlineData(100, 9, 1)]
    public void GetLeftover_ReturnsExpectedResult(
        int itemCount,
        int groupSize,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson05ModuloOperator.Exercise01.MainClass
                .GetLeftover(itemCount, groupSize);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(47, 10, 7)]
    [InlineData(36, 6, 0)]
    [InlineData(14, 4, 2)]
    [InlineData(5, 12, 5)]
    [InlineData(73, 8, 1)]
    [InlineData(100, 12, 4)]
    public void GetUnpackedCount_ReturnsExpectedResult(
        int productCount,
        int productsPerBox,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson05ModuloOperator.Exercise02.MainClass
                .GetUnpackedCount(productCount, productsPerBox);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(347, 7)]
    [InlineData(82, 2)]
    [InlineData(900, 0)]
    [InlineData(6, 6)]
    [InlineData(1234, 4)]
    [InlineData(0, 0)]
    [InlineData(987654, 4)]
    public void GetLastDigit_ReturnsExpectedResult(
        int number,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson05ModuloOperator.Exercise03.MainClass
                .GetLastDigit(number);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(135, 15)]
    [InlineData(60, 0)]
    [InlineData(59, 59)]
    [InlineData(185, 5)]
    [InlineData(240, 0)]
    [InlineData(0, 0)]
    [InlineData(721, 1)]
    public void GetRemainingMinutes_ReturnsExpectedResult(
        int totalMinutes,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson05ModuloOperator.Exercise04.MainClass
                .GetRemainingMinutes(totalMinutes);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(53, 10, 3)]
    [InlineData(24, 5, 4)]
    [InlineData(7, 20, 7)]
    [InlineData(40, 8, 0)]
    [InlineData(0, 10, 0)]
    [InlineData(101, 25, 1)]
    [InlineData(99, 10, 9)]
    public void GetItemsOnPartialPage_ReturnsExpectedResult(
        int totalItems,
        int itemsPerPage,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson05ModuloOperator.Exercise05.MainClass
                .GetItemsOnPartialPage(totalItems, itemsPerPage);

        Assert.Equal(expected, actual);
    }
}