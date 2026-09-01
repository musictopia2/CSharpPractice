namespace CSharpPracticeLibrary.Section05Loops.Lesson03ForLoops.Exercise03;
public static class MainClass
{
    public static void DisplayPackagesForSpecialCheck()
    {
        18.Times(x =>
        {
            Console.WriteLine($"Package {x}");
        }, 3);
    }
}