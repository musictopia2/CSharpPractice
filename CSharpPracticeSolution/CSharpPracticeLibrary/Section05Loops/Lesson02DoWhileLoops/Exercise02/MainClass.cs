namespace CSharpPracticeLibrary.Section05Loops.Lesson02DoWhileLoops.Exercise02;
public static class MainClass
{
    public static int ProcessShippingLabels(int labelCount)
    {
        int upTo = 0;
        do
        {
            upTo++;
            //processing.
            if (upTo == labelCount)
            {
                return upTo;
            }

        } while (true);
    }
}