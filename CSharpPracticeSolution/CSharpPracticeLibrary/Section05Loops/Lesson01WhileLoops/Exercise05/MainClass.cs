namespace CSharpPracticeLibrary.Section05Loops.Lesson01WhileLoops.Exercise05;
public static class MainClass
{
    public static int CountAttemptsUntilDivisible(int startingValue, int divisor)
    {
        int required = 0;
        int numberUpTo = startingValue;
        do
        {
            int leftOvers = numberUpTo.Remainder(divisor);
            if (leftOvers == 0)
            {
                return required;
            }
            required++;
            numberUpTo++;
        } while (true);
    }
    public static int CountAttemptsUntilDivisible2(int startingValue, int divisor)
    {
        int required = 0;
        int numberUpTo = startingValue;
        int leftOvers = numberUpTo.Remainder(divisor);

        while (leftOvers != 0)
        {
            required++;
            numberUpTo++;

            leftOvers = numberUpTo.Remainder(divisor);
        }

        return required;
    }
}