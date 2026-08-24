namespace Division.Section01HelloWorld.Lesson09Review;
[Trait("Section", "Section01HelloWorld")]
public class ExercisesClass
{
    [Fact]
    public void PrintPracticeStatus_PrintsExpectedOutput()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section01HelloWorld.Lesson09Review.Exercise01.MainClass.PrintPracticeStatus();

        // Assert
        string expected =
            "Course: C# Fundamentals" + Environment.NewLine +
            "Lessons Completed: 8" + Environment.NewLine +
            "Status: Section Complete" + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintDeveloperProfile_PrintsProfileUsingUserInput()
    {
        // Arrange
        string input =
            "Jordan" + Environment.NewLine +
            "Variables" + Environment.NewLine;

        StringReader reader = new(input);
        StringWriter writer = new();

        Console.SetIn(reader);
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section01HelloWorld.Lesson09Review.Exercise02.MainClass.PrintDeveloperProfile();

        // Assert
        string expected =
            "Enter your name: " +
            "Enter your current lesson: " +
            "Developer: Jordan" + Environment.NewLine +
            "Language: C#" + Environment.NewLine +
            "Current Lesson: Variables" + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintPracticeSession_PrintsExpectedSummary()
    {
        // Arrange
        string input =
            "Morgan" + Environment.NewLine +
            "Constants" + Environment.NewLine +
            "In Progress" + Environment.NewLine;

        StringReader reader = new(input);
        StringWriter writer = new();

        Console.SetIn(reader);
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section01HelloWorld.Lesson09Review.Exercise03.MainClass.PrintPracticeSession();

        // Assert
        string expected =
            "Enter your name: " +
            "Enter the practice topic: " +
            "Enter the session status: " +
            "Program: C# Practice Tracker" + Environment.NewLine +
            "Student: Morgan" + Environment.NewLine +
            "Topic: Constants" + Environment.NewLine +
            "Session Status: In Progress" + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintShippingLabel_PrintsExpectedShippingLabel()
    {
        // Arrange
        string input =
            "Morgan Lee" + Environment.NewLine +
            "Austin" + Environment.NewLine +
            "TX" + Environment.NewLine;

        StringReader reader = new(input);
        StringWriter writer = new();

        Console.SetIn(reader);
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section01HelloWorld.Lesson09Review.Exercise04.MainClass.PrintShippingLabel();

        // Assert
        string expected =
            "Enter recipient name: " +
            "Enter city: " +
            "Enter state: " +
            "====================" + Environment.NewLine +
            "North Star Supplies" + Environment.NewLine +
            "SHIP TO: Morgan Lee" + Environment.NewLine +
            "Austin, TX" + Environment.NewLine +
            "====================" + Environment.NewLine;

        string actual = writer.ToString();

        Assert.True(
            expected == actual,
            $"""
            Console output did not match the requirement.

            EXPECTED:
            --------------------
            {expected}
            --------------------

            ACTUAL:
            --------------------
            {actual}
            --------------------
            """);
    }

    [Fact]
    public void PrintPracticeReceipt_PrintsExpectedReceipt()
    {
        // Arrange
        string input =
            "Jordan Smith" + Environment.NewLine +
            "Variables" + Environment.NewLine +
            "Exercise 5" + Environment.NewLine +
            "Passed" + Environment.NewLine;

        StringReader reader = new(input);
        StringWriter writer = new();

        Console.SetIn(reader);
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section01HelloWorld.Lesson09Review.Exercise05.MainClass.PrintPracticeReceipt();

        // Assert
        string expected =
            "Enter learner name: " +
            "Enter topic practiced: " +
            "Enter exercise completed: " +
            "Enter session result: " +
            "================================" + Environment.NewLine +
            "CodeWorks Training Center" + Environment.NewLine +
            "PRACTICE SESSION RECEIPT" + Environment.NewLine +
            "================================" + Environment.NewLine +
            "Learner: Jordan Smith" + Environment.NewLine +
            "Topic: Variables" + Environment.NewLine +
            "Exercise: Exercise 5" + Environment.NewLine +
            "Result: Passed" + Environment.NewLine +
            "--------------------------------" + Environment.NewLine +
            "Status: Session Recorded" + Environment.NewLine +
            "================================" + Environment.NewLine;

        string actual = writer.ToString();

        Assert.True(
            expected == actual,
            $"""
            Console output did not match the requirement.

            EXPECTED:
            --------------------
            {expected}
            --------------------

            ACTUAL:
            --------------------
            {actual}
            --------------------
            """);
    }


}