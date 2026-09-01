namespace CSharpPracticeLibrary.Section05Loops.Lesson03ForLoops.Exercise04;
public static class MainClass
{
    public static int CountQualityFailures(int numberOfItems)
    {
        int failures = 0;

        numberOfItems.Times(x =>
        {
            int leftOvers = x.Remainder(4);
            if (leftOvers == 0)
            {
                failures++;
            }
        });
        return failures;
    }
}