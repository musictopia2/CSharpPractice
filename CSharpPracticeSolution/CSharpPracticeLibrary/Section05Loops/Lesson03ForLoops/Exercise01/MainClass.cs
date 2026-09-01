namespace CSharpPracticeLibrary.Section05Loops.Lesson03ForLoops.Exercise01;
public static class MainClass
{
    public static void DisplayInspectionStations()
    {
        8.Times(x =>
        {
            Console.WriteLine($"Inspection Station: {x}");
        });
    }
}