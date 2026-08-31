namespace CSharpPracticeLibrary.Section05Loops.Lesson02DoWhileLoops.Exercise01;
public static class MainClass
{
    public static void DisplayProductionChecks()
    {
        int upTo = 0;
        do
        {
            upTo++;
            Console.WriteLine("=== PRODUCTION CHECK ===");
            Console.WriteLine("Machine Status: Running");
            Console.WriteLine("Safety Check: Passed");
            Console.WriteLine($"Check Number: {upTo}");
            if (upTo == 3)
            {
                return;
            }

        } while (true);
    }
}