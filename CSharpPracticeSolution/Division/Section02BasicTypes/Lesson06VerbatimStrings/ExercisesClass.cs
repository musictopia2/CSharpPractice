namespace Division.Section02BasicTypes.Lesson06VerbatimStrings;
[Trait("Section", "Section02BasicTypes")]
public class ExercisesClass
{
    [Fact]
    public void PrintBackupLocations_PrintsExpectedBackupLocations()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section02BasicTypes.Lesson06VerbatimStrings.Exercise01.MainClass.PrintBackupLocations();

            string expected =
                $@"C:\GameData\Profiles\player.dat{Environment.NewLine}" +
                $@"E:\Backups\Weekly\settings.json{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintNetworkLocations_PrintsExpectedNetworkLocations()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section02BasicTypes.Lesson06VerbatimStrings.Exercise02.MainClass.PrintNetworkLocations();

            string expected =
                $@"\\OfficeServer\Documents\Invoices{Environment.NewLine}" +
                $@"\\BackupServer\Archives\2026{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintFileInstructions_PrintsExpectedInstructions()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section02BasicTypes.Lesson06VerbatimStrings.Exercise03.MainClass.PrintFileInstructions();

            string expected =
                $"Open the \"Exports\" folder and select \"customers.csv\".{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Theory]
    [InlineData("orders.txt")]
    [InlineData("customers.csv")]
    [InlineData("backup.json")]
    public void PrintExportLocation_PrintsExpectedLocation(string fileName)
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section02BasicTypes.Lesson06VerbatimStrings.Exercise04.MainClass.PrintExportLocation(fileName);

            string expected =
                $"Export folder: C:\\ApplicationData\\Exports{Environment.NewLine}" +
                $"File: {fileName}{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Theory]
    [InlineData("Inventory Manager")]
    [InlineData("Order Tracker")]
    [InlineData("Backup Utility")]
    public void PrintDeploymentSettings_PrintsExpectedSettings(string applicationName)
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            CSharpPracticeLibrary.Section02BasicTypes.Lesson06VerbatimStrings.Exercise05.MainClass.PrintDeploymentSettings(applicationName);

            string expected =
                $"Application: \"{applicationName}\"{Environment.NewLine}" +
                $"Configuration: C:\\CompanyTools\\Deployment\\Config{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
}