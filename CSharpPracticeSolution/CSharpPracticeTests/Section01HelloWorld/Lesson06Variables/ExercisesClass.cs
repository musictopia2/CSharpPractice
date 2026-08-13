namespace CSharpPracticeTests.Section01HelloWorld.Lesson06Variables;
[Trait("Section", "Section01HelloWorld")]
public class ExercisesClass
{
    [Theory]
    [InlineData(5, 15)]
    [InlineData(3, 9)]
    [InlineData(10, 30)]
    [InlineData(0, 0)]
    [InlineData(-4, -12)]
    public void TripleNumber_ReturnsNumberMultipliedByThree(int number, int expected)
    {
        int actual = CSharpPracticeLibrary.Section01HelloWorld.Lesson06Variables.Exercise01.MainClass.TripleNumber(number);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, 3, 7)]
    [InlineData(20, 5, 15)]
    [InlineData(8, 8, 0)]
    [InlineData(100, 25, 75)]
    [InlineData(5, 10, -5)]
    public void CalculateRemainingItems_ReturnsDifference(
        int totalItems,
        int usedItems,
        int expected)
    {
        int actual = CSharpPracticeLibrary.Section01HelloWorld.Lesson06Variables.Exercise02.MainClass.CalculateRemainingItems(
            totalItems,
            usedItems);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5.00, 2, 10.00)]
    [InlineData(2.50, 4, 10.00)]
    [InlineData(9.99, 3, 29.97)]
    [InlineData(1.25, 8, 10.00)]
    [InlineData(0.00, 5, 0.00)]
    public void CalculateTotalPrice_ReturnsPriceMultipliedByQuantity(
        double itemPrice,
        int quantity,
        double expected)
    {
        double actual = CSharpPracticeLibrary.Section01HelloWorld.Lesson06Variables.Exercise03.MainClass.CalculateTotalPrice(
            itemPrice,
            quantity);

        Assert.Equal(expected, actual, 2);
    }
    [Theory]
    [InlineData(true, true)]
    [InlineData(false, false)]
    public void GetGameStatus_ReturnsProvidedGameStatus(
        bool isGameOver,
        bool expected)
    {
        bool actual = CSharpPracticeLibrary.Section01HelloWorld.Lesson06Variables.Exercise04.MainClass.GetGameStatus(
            isGameOver);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("Alice", "Welcome, Alice")]
    [InlineData("Bob", "Welcome, Bob")]
    [InlineData("Sam", "Welcome, Sam")]
    [InlineData("Alex", "Welcome, Alex")]
    [InlineData("", "Welcome, ")]
    public void CreateWelcomeMessage_ReturnsWelcomeMessage(
        string name,
        string expected)
    {
        string actual = CSharpPracticeLibrary.Section01HelloWorld.Lesson06Variables.Exercise05.MainClass.CreateWelcomeMessage(
            name);

        Assert.Equal(expected, actual);
    }
}