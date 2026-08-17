namespace CSharpPracticeTests.Section02BasicTypes.Lesson07EscapeSequences;
[Trait("Section", "Section02BasicTypes")]
public class ExercisesClass
{
    [Fact]
    public void PrintDeveloperNote_PrintsExpectedOutput()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson07EscapeSequences.Exercise01.MainClass.PrintDeveloperNote();

        // Assert
        string expected =
            "\"Build completed successfully!\"" + Environment.NewLine +
            @"Log: C:\Development\Logs" + Environment.NewLine +
            "\tStatus: Ready" + Environment.NewLine +
            "Next step: Review" + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintSaveReport_PrintsExpectedOutput()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson07EscapeSequences.Exercise02.MainClass.PrintSaveReport();

        // Assert
        string expected =
            "Player:\tAlex" + Environment.NewLine +
            @"Save Location: D:\Games\Profiles\Alex" + Environment.NewLine +
            "Message: \"Save completed.\"" + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
    [Theory]
    [InlineData("Alpha")]
    [InlineData("Production")]
    [InlineData("Server01")]
    public void PrintConnectionDetails_PrintsExpectedOutput(string serverName)
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson07EscapeSequences.Exercise03.MainClass.PrintConnectionDetails(serverName);

        // Assert
        string expected =
            $"Server:\t{serverName}" + Environment.NewLine +
            $@"Config: C:\Network\Servers\{serverName}" + Environment.NewLine +
            "Message: \"Connection ready.\"" + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
    [Theory]
    [InlineData("GameEngine", 3)]
    [InlineData("InventoryTool", 0)]
    [InlineData("ReportGenerator", 12)]
    public void PrintBuildSummary_PrintsExpectedOutput(string projectName, int warningCount)
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson07EscapeSequences.Exercise04.MainClass.PrintBuildSummary(projectName, warningCount);

        // Assert
        string expected =
            $"Project:\t{projectName}" + Environment.NewLine +
            $"Warnings:\t{warningCount}" + Environment.NewLine +
            $@"Output: C:\Builds\{projectName}" + Environment.NewLine +
            "Message: \"Build review required.\"" + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
    [Theory]
    [InlineData("Inventory Manager", "2.5")]
    [InlineData("Billing Tool", "1.0")]
    [InlineData("Report Studio", "10.3")]
    public void PrintDeploymentReceipt_PrintsExpectedOutput(string applicationName, string version)
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson07EscapeSequences.Exercise05.MainClass.PrintDeploymentReceipt(applicationName, version);

        // Assert
        string expected =
            $"Application:\t{applicationName}" + Environment.NewLine +
            $"Version:\t{version}" + Environment.NewLine +
            $@"Install Directory: C:\Applications\{applicationName}" + Environment.NewLine +
            "Status: \"Deployment complete.\"" + Environment.NewLine;

        Assert.Equal(expected, writer.ToString());
    }
}