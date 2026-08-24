namespace Division.Section01HelloWorld.Lesson07Constants;
[Trait("Section", "Section01HelloWorld")]
public class ExercisesClass
{
     [Fact]
    public void GetMaximumUsers_Returns25()
    {
        int result =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise01.MainClass.GetMaximumUsers();

        Assert.Equal(25, result);
    }

    [Fact]
    public void GetHoursPerWeek_Returns168()
    {
        int result =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise01.MainClass.GetHoursPerWeek();

        Assert.Equal(168, result);
    }

    [Fact]
    public void GetApplicationTitle_ReturnsPracticeTracker()
    {
        string result =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise01.MainClass.GetApplicationTitle();

        Assert.Equal("Practice Tracker", result);
    }
    [Fact]
    public void GetMatchesPerDay_Returns6()
    {
        int result =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise02.MainClass.GetMatchesPerDay();

        Assert.Equal(6, result);
    }

    [Fact]
    public void GetMaximumWeeklyMatches_Returns42()
    {
        int result =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise02.MainClass.GetMaximumWeeklyMatches();

        Assert.Equal(42, result);
    }
    [Fact]
    public void GetStoreName_ReturnsCornerMarket()
    {
        string result =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise03.MainClass.GetStoreName();

        Assert.Equal("Corner Market", result);
    }

    [Fact]
    public void GetMaximumItems_Returns50()
    {
        int result =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise03.MainClass.GetMaximumItems();

        Assert.Equal(50, result);
    }

    [Fact]
    public void GetSalesTaxRate_ReturnsPointZeroEight()
    {
        double result =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise03.MainClass.GetSalesTaxRate();

        Assert.Equal(0.08, result);
    }
    [Fact]
    public void PrintSessionSummary_PrintsExpectedOutput()
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise04.MainClass.PrintSessionSummary();

        string expected =
            $"Skill Builder{Environment.NewLine}" +
            $"5{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }


    [Fact]
    public void GetEventName_ReturnsSummerCodingDay()
    {
        string result =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise05.MainClass.GetEventName();

        Assert.Equal("Summer Coding Day", result);
    }

    [Fact]
    public void GetMaximumAttendees_Returns75()
    {
        int result =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise05.MainClass.GetMaximumAttendees();

        Assert.Equal(75, result);
    }

    [Fact]
    public void GetRegistrationFee_ReturnsTwelvePointFive()
    {
        double result =
            CSharpPracticeLibrary.Section01HelloWorld.Lesson07Constants.Exercise05.MainClass.GetRegistrationFee();

        Assert.Equal(12.50, result);
    }

}