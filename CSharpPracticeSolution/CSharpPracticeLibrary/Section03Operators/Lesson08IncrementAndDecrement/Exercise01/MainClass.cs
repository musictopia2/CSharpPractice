namespace CSharpPracticeLibrary.Section03Operators.Lesson08IncrementAndDecrement.Exercise01;

public static class MainClass
{
    public static int GetOriginalThenIncrease(int number)
    {
        return number++;
    }

    public static int IncreaseThenGet(int number)
    {
        return ++number;
    }

    public static int GetOriginalThenDecrease(int number)
    {
        return number--;
    }

    public static int DecreaseThenGet(int number)
    {
        return --number;
    }
}