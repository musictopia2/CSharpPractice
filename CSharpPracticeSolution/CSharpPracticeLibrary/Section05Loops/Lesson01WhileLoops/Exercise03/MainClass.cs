namespace CSharpPracticeLibrary.Section05Loops.Lesson01WhileLoops.Exercise03;
public static class MainClass
{
    public static int IncreaseToTarget(int startingValue)
    {
        int finalValue;
        finalValue = startingValue;
        do
        {
            if (finalValue >= 10)
            {
                return finalValue;
            }
            finalValue += 3;
            
        } while (true);
    }
    public static int IncreaseToTarget2(int startingValue)
    {
        int finalValue;
        finalValue = startingValue;

        while (finalValue < 10)
        {
            finalValue += 3;
        }

        return finalValue;
    }
}