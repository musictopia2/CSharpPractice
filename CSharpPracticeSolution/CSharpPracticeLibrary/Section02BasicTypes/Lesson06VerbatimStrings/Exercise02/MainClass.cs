namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson06VerbatimStrings.Exercise02;
public static class MainClass
{
    public static void PrintNetworkLocations()
    {
        string firstPath = @"\\OfficeServer\Documents\Invoices";
        string secondPath = @"\\BackupServer\Archives\2026";
        Console.WriteLine(firstPath);
        Console.WriteLine(secondPath);
    }
}