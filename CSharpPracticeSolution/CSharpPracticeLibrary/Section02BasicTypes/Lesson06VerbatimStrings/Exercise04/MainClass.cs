namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson06VerbatimStrings.Exercise04;
public static class MainClass
{
    public static void PrintExportLocation(string fileName)
    {
        string folderLocation = @"C:\ApplicationData\Exports";
        Console.WriteLine($@"Export folder: {folderLocation}");
        Console.WriteLine($"File: {fileName}");
    }
}