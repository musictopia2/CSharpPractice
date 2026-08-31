namespace CSharpPracticeLibrary.Section05Loops.Lesson02DoWhileLoops.Exercise05;
public static class MainClass
{
    public static int FindNextPackageSize(
    int startingSize,
    int packageMultiple)
    {
        int leftOvers;
        int upTo = startingSize;
        do
        {
            upTo++;
            leftOvers = upTo.Remainder(packageMultiple);
            if (leftOvers == 0)
            {
                return upTo;
            }
        } while (true);
    }
}