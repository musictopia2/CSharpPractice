namespace CSharpPracticeTests.Section01HelloWorld.Lesson01ConsolePrinting;

[Trait("Section", "Section01HelloWorld")]
public class ExercisesClass
{
    [Fact]
    public void PrintEventInfo_PrintsExpectedEventInformation()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson01ConsolePrinting.Exercise01.MainClass.PrintEventInfo();

            string expected =
                $"Summer Festival{Environment.NewLine}" +
                $"Central Park{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintShippingLabel_PrintsExpectedShippingInformation()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson01ConsolePrinting.Exercise02.MainClass.PrintShippingLabel();

            string expected =
                $"Morgan Reed{Environment.NewLine}" +
                $"42 Pine Avenue{Environment.NewLine}" +
                $"Riverton{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintStoreHours_PrintsExpectedStoreHours()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson01ConsolePrinting.Exercise03.MainClass.PrintStoreHours();

            string expected =
                $"Northside Books{Environment.NewLine}" +
                $"Monday-Friday: 9 AM - 6 PM{Environment.NewLine}" +
                $"Saturday: 10 AM - 4 PM{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintContactCard_PrintsInformationInRequiredOrder()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson01ConsolePrinting.Exercise04.MainClass.PrintContactCard();

            string expected =
                $"Jordan Lee{Environment.NewLine}" +
                $"Available{Environment.NewLine}" +
                $"jordan.lee@example.com{Environment.NewLine}" +
                $"Oakridge{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintAppointmentSummary_PrintsExpectedSummary()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson01ConsolePrinting.Exercise05.MainClass.PrintAppointmentSummary();

            string expected =
                $"Appointment{Environment.NewLine}" +
                $"Dr. Rivera{Environment.NewLine}" +
                $"Tuesday, 2:30 PM{Environment.NewLine}" +
                $"Room 204{Environment.NewLine}" +
                $"Confirmed{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }


}
