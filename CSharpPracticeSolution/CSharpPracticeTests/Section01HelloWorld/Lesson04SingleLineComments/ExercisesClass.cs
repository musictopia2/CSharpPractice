namespace CSharpPracticeTests.Section01HelloWorld.Lesson04SingleLineComments;
[Trait("Section", "Section01HelloWorld")]
public class ExercisesClass
{
    [Fact]
    public void PrintOrderStatus_PrintsExpectedOutput()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section01HelloWorld.Lesson04SingleLineComments
            .Exercise01.MainClass.PrintOrderStatus();

        // Assert
        string expected =
            $"Order received{Environment.NewLine}" +
            $"Order complete{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintCalculation_PrintsExpectedOutput()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section01HelloWorld.Lesson04SingleLineComments
            .Exercise02.MainClass.PrintCalculation();

        // Assert
        string expected =
            $"Calculation complete{Environment.NewLine}" +
            $"15{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintLaunchStatus_PrintsExpectedOutput()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section01HelloWorld.Lesson04SingleLineComments
            .Exercise03.MainClass.PrintLaunchStatus();

        // Assert
        string expected =
            $"Preparing launch{Environment.NewLine}" +
            $"Launch ready{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintPlayerName_PrintsEnteredName()
    {
        // Arrange
        StringReader reader = new("Jordan");
        StringWriter writer = new();

        Console.SetIn(reader);
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section01HelloWorld.Lesson04SingleLineComments
            .Exercise04.MainClass.PrintPlayerName();

        // Assert
        string expected = $"Jordan{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void ShowApplicationStatus_PrintsExpectedOutput()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section01HelloWorld.Lesson04SingleLineComments
            .Exercise05.MainClass.ShowApplicationStatus();

        // Assert
        string expected =
            $"Application starting...{Environment.NewLine}" +
            $"Ready for user{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }
}