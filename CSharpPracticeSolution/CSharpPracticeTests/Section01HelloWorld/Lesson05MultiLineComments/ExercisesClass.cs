namespace CSharpPracticeTests.Section01HelloWorld.Lesson05MultiLineComments;
[Trait("Section", "Section01HelloWorld")]
public class ExercisesClass
{
    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, 10, 5)]
    [InlineData(25, -10, 15)]
    [InlineData(-8, -7, -15)]
    public void GetTotalScore_ReturnsExpectedTotal(
       int firstScore,
       int secondScore,
       int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section01HelloWorld
                .Lesson05MultiLineComments.Exercise01
                .MainClass.GetTotalScore(firstScore, secondScore);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(100, 25, 75)]
    [InlineData(50, 50, 0)]
    [InlineData(20, 30, -10)]
    [InlineData(75, 10, 65)]
    [InlineData(-10, 5, -15)]
    public void GetScoreDifference_ReturnsExpectedDifference(
        int startingScore,
        int pointsLost,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section01HelloWorld
                .Lesson05MultiLineComments.Exercise02
                .MainClass.GetScoreDifference(startingScore, pointsLost);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5, 3, 15)]
    [InlineData(10, 4, 40)]
    [InlineData(7, 0, 0)]
    [InlineData(12, 2, 24)]
    [InlineData(1, 100, 100)]
    public void GetTotalPrice_ReturnsExpectedTotal(
        int itemPrice,
        int quantity,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section01HelloWorld
                .Lesson05MultiLineComments.Exercise03
                .MainClass.GetTotalPrice(itemPrice, quantity);

        Assert.Equal(expected, actual);
    }
    [Fact]
    public void PrintWelcomeMessage_PrintsExpectedMessage()
    {
        StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section01HelloWorld
            .Lesson05MultiLineComments.Exercise04
            .MainClass.PrintWelcomeMessage();

        string actual = writer.ToString();

        Assert.Equal($"Welcome, Developer!{Environment.NewLine}", actual);
    }
    [Fact]
    public void PrintSystemStatus_PrintsExpectedStatus()
    {
        StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section01HelloWorld
            .Lesson05MultiLineComments.Exercise05
            .MainClass.PrintSystemStatus();

        string actual = writer.ToString();

        string expected =
            $"System Status{Environment.NewLine}" +
            $"Current state: Ready{Environment.NewLine}";

        Assert.Equal(expected, actual);
    }
}