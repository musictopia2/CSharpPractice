namespace Division.Section02BasicTypes.Lesson04Strings;
[Trait("Section", "Section02BasicTypes")]
public class ExercisesClass
{
    [Fact]
    public void PrintWelcomeMessage_PrintsExpectedMessage()
    {
        // Arrange
        StringWriter output = new();
        TextWriter originalOutput = Console.Out;

        try
        {
            Console.SetOut(output);

            // Act
            CSharpPracticeLibrary.Section02BasicTypes.Lesson04Strings.Exercise01.MainClass.PrintWelcomeMessage();

            // Assert
            string actual = output.ToString();
            string expected = $"Welcome to C# Practice!{Environment.NewLine}";

            Assert.Equal(expected, actual);
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintProductName_PrintsExpectedProductName()
    {
        // Arrange
        StringWriter output = new();
        TextWriter originalOutput = Console.Out;

        try
        {
            Console.SetOut(output);

            // Act
            CSharpPracticeLibrary.Section02BasicTypes.Lesson04Strings.Exercise02.MainClass.PrintProductName();

            // Assert
            string actual = output.ToString();
            string expected = $"Wireless Keyboard{Environment.NewLine}";

            Assert.Equal(expected, actual);
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintOrderCode_PrintsExpectedOrderCode()
    {
        // Arrange
        StringWriter output = new();
        TextWriter originalOutput = Console.Out;

        try
        {
            Console.SetOut(output);

            // Act
            CSharpPracticeLibrary.Section02BasicTypes.Lesson04Strings.Exercise03.MainClass.PrintOrderCode();

            // Assert
            string actual = output.ToString();
            string expected = $"Order #5821 - Ready!{Environment.NewLine}";

            Assert.Equal(expected, actual);
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintGameStatus_PrintsGameNameAndLevel()
    {
        // Arrange
        StringWriter output = new();
        TextWriter originalOutput = Console.Out;

        try
        {
            Console.SetOut(output);

            // Act
            CSharpPracticeLibrary.Section02BasicTypes.Lesson04Strings.Exercise04.MainClass.PrintGameStatus();

            // Assert
            string actual = output.ToString();
            string expected =
                $"Code Quest{Environment.NewLine}" +
                $"7{Environment.NewLine}";

            Assert.Equal(expected, actual);
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintServiceInformation_PrintsExpectedServiceInformation()
    {
        // Arrange
        StringWriter output = new();
        TextWriter originalOutput = Console.Out;

        try
        {
            Console.SetOut(output);

            // Act
            CSharpPracticeLibrary.Section02BasicTypes.Lesson04Strings.Exercise05.MainClass.PrintServiceInformation();

            // Assert
            string actual = output.ToString();
            string expected =
                $"QuickFix Support{Environment.NewLine}" +
                $"Available Now{Environment.NewLine}" +
                $"HELP-2048{Environment.NewLine}";

            Assert.Equal(expected, actual);
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
}