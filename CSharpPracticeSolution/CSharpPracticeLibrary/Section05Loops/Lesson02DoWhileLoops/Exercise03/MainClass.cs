namespace CSharpPracticeLibrary.Section05Loops.Lesson02DoWhileLoops.Exercise03;
public static class MainClass
{
    public static int CountInspectionAttempts(int startingScore, int requiredScore)
    {
        int upTo = startingScore;
        int attempts = 0;
        do
        {
            upTo += 2;
            attempts++;
            if (upTo >= requiredScore)
            {
                return attempts;
            }
        } while (true);
    }
}