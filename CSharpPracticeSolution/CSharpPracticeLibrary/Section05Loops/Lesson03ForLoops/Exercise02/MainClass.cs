namespace CSharpPracticeLibrary.Section05Loops.Lesson03ForLoops.Exercise02;
public static class MainClass
{
    public static void DisplayStartupCountdown()
    {
        int downTo = 6;
        downTo.Times(() =>
        {
            Console.WriteLine(downTo);
            downTo--;
        });
        Console.WriteLine("Machine Started");
    }
}