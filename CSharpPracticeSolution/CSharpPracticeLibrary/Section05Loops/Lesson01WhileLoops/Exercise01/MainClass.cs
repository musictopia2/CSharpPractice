namespace CSharpPracticeLibrary.Section05Loops.Lesson01WhileLoops.Exercise01;
public static class MainClass
{
    public static void PrintCheckpoints()
    {
        int x = 3;
        do
        {
            Console.WriteLine(x);
            x++;
            if (x > 7)
            {
                return;
            }
        } while (true);
    }
    public static void PrintCheckpoints2()
    {
        int x = 3;

        while (x <= 7)
        {
            Console.WriteLine(x);
            x++;
        }
    }
}