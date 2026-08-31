namespace CSharpPracticeLibrary.Section05Loops.Lesson01WhileLoops.Exercise02;
public static class MainClass
{
    public static void PrintCountdown()
    {
        int x = 8;
        do
        {
            Console.WriteLine(x);
            x--;
            if (x == 1)
            {
                return;
            }
        } while (true);
    }
    public static void PrintCountdown2()
    {
        int x = 8;

        while (x >= 2)
        {
            Console.WriteLine(x);
            x--;
        }
    }
}