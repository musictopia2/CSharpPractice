namespace Division.Section02BasicTypes.Lesson05StringConcatenation;
[Trait("Section", "Section02BasicTypes")]
public class ExercisesClass
{
    [Fact]
    public void PrintPlayerSummary_PrintsExpectedSummary()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson05StringConcatenation.Exercise01.MainClass
            .PrintPlayerSummary("Morgan", 12);

        // Assert
        string expected =
            "Player: Morgan" + Environment.NewLine +
            "Level: 12" + Environment.NewLine +
            "Morgan has reached level 12." + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintGameStatus_PrintsExpectedStatus()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson05StringConcatenation.Exercise02.MainClass
            .PrintGameStatus("Castle Quest", 8);

        // Assert
        string expected =
            "Game: Castle Quest" + Environment.NewLine +
            "Players: 8" + Environment.NewLine +
            "Castle Quest currently has 8 players online." + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintProductLabel_PrintsExpectedLabel()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson05StringConcatenation.Exercise03.MainClass
            .PrintProductLabel("Notebook", 4, 2.5);

        // Assert
        string expected =
            "Product: Notebook" + Environment.NewLine +
            "Quantity: 4" + Environment.NewLine +
            "Price: $2.5" + Environment.NewLine +
            "4 units of Notebook cost $2.5 each." + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintPracticeReport_PrintsExpectedReport()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson05StringConcatenation.Exercise04.MainClass
            .PrintPracticeReport("String Concatenation", 3, 2);

        // Assert
        string expected =
            "Topic: String Concatenation" + Environment.NewLine +
            "Completed: 3" + Environment.NewLine +
            "Remaining: 2" + Environment.NewLine +
            "Practice progress: 3 completed, 2 remaining." + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintDeliveryConfirmation_PrintsExpectedConfirmation()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson05StringConcatenation.Exercise05.MainClass
            .PrintDeliveryConfirmation("Jordan Lee", "Storage Box", 3);

        // Assert
        string expected =
            "Customer: Jordan Lee" + Environment.NewLine +
            "Item: Storage Box" + Environment.NewLine +
            "Quantity: 3" + Environment.NewLine +
            "Delivery ready: 3 Storage Box for Jordan Lee." + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
}