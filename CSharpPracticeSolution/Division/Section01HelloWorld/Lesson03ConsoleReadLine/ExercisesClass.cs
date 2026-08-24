namespace Division.Section01HelloWorld.Lesson03ConsoleReadLine;
[Trait("Section", "Section01HelloWorld")]
public class ExercisesClass
{
    [Fact]
    public void PrintFavoriteFood_ReadsAndPrintsFavoriteFood()
    {
        TextReader originalInput = Console.In;
        TextWriter originalOutput = Console.Out;

        StringReader reader = new("Pizza");
        StringWriter writer = new();

        try
        {
            Console.SetIn(reader);
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson03ConsoleReadLine
                .Exercise01.MainClass.PrintFavoriteFood();

            string expected = $"Pizza{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintCity_ReadsAndPrintsCity()
    {
        TextReader originalInput = Console.In;
        TextWriter originalOutput = Console.Out;

        StringReader reader = new("Seattle");
        StringWriter writer = new();

        try
        {
            Console.SetIn(reader);
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson03ConsoleReadLine
                .Exercise02.MainClass.PrintCity();

            string expected =
                $"City:{Environment.NewLine}" +
                $"Seattle{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintHobby_ReadsAndPrintsHobby()
    {
        TextReader originalInput = Console.In;
        TextWriter originalOutput = Console.Out;

        StringReader reader = new("Photography");
        StringWriter writer = new();

        try
        {
            Console.SetIn(reader);
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson03ConsoleReadLine
                .Exercise03.MainClass.PrintHobby();

            string expected =
                $"Hobby selected:{Environment.NewLine}" +
                $"Photography{Environment.NewLine}" +
                $"Enjoy your hobby!{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintUsername_ReadsAndPrintsUsername()
    {
        TextReader originalInput = Console.In;
        TextWriter originalOutput = Console.Out;

        StringReader reader = new("SkyRunner");
        StringWriter writer = new();

        try
        {
            Console.SetIn(reader);
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson03ConsoleReadLine
                .Exercise04.MainClass.PrintUsername();

            string expected = $"Username: SkyRunner{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void CheckInVisitor_ReadsAndPrintsVisitorName()
    {
        TextReader originalInput = Console.In;
        TextWriter originalOutput = Console.Out;

        StringReader reader = new("Jordan");
        StringWriter writer = new();

        try
        {
            Console.SetIn(reader);
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section01HelloWorld.Lesson03ConsoleReadLine
                .Exercise05.MainClass.CheckInVisitor();

            string expected =
                $"Visitor: Jordan{Environment.NewLine}" +
                $"Check-in complete.{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }
}