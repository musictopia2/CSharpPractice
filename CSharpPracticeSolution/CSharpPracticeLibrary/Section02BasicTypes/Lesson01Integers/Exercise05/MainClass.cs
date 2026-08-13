namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson01Integers.Exercise05;
public static class MainClass
{
    public static int GetNetBalance(
    int startingBalance,
    int moneyAdded,
    int moneySpent)
    {
        return startingBalance + moneyAdded - moneySpent;
    }
    public static int GetDoubleBalance(int balance)
    {
        return balance * 2;
    }
    public static int GetMinimumInteger()
    {
        return int.MinValue;
    }
    public static int GetMaximumInteger()
    {
        return int.MaxValue;
    }

}