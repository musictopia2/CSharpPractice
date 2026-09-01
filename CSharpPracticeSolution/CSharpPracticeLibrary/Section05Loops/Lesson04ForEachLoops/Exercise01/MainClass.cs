namespace CSharpPracticeLibrary.Section05Loops.Lesson04ForEachLoops.Exercise01;
public static class MainClass
{
    public static void PrintInspectionAreas(string[] areas)
    {
        foreach (var area in areas)
        {
            Console.WriteLine(area);
        }
    }
}