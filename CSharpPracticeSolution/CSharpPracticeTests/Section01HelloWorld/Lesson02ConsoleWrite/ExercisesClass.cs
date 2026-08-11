namespace CSharpPracticeTests.Section01HelloWorld.Lesson02ConsoleWrite;
public class ExercisesClass
{
    [Fact]
    public void PrintMessage_PrintsExpectedMessage()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson02ConsoleWrite.Exercise01.MainClass.PrintMessage();

            string expected = $"C# is fun!{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintLoadingStatus_PrintsExpectedStatus()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson02ConsoleWrite.Exercise02.MainClass.PrintLoadingStatus();

            string expected = $"Loading...Done!{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintScore_PrintsExpectedOutput()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson02ConsoleWrite.Exercise03.MainClass.PrintScore();

            string expected =
                $"Score: 100{Environment.NewLine}" +
                $"Game Complete!{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintOrderSummary_PrintsExpectedOutput()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson02ConsoleWrite.Exercise04.MainClass.PrintOrderSummary();

            string expected =
                $"Order Summary{Environment.NewLine}" +
                $"Item: Notebook{Environment.NewLine}" +
                $"Quantity: 3{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintSaveConfirmation_PrintsExpectedOutput()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson02ConsoleWrite.Exercise05.MainClass.PrintSaveConfirmation();

            string expected =
                $"Settings saved for: Alex{Environment.NewLine}" +
                $"Status: Complete{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
}