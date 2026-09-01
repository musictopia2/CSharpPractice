namespace CSharpPracticeLibrary.Section05Loops.Lesson06NestedLoops.Exercise01;
public static class MainClass
{
    public static void DisplayStorageLocations()
    {
        3.Times(a =>
        {
            4.Times(s =>
            {
                Console.WriteLine($"Aisle {a} - Shelf {s}");
            });
        });
    }
}