namespace CSharpPracticeLibrary.Section06Methods.Lesson09RefParameters.Exercise01;
public static class MainClass
{
    public static void ExchangeCounts(ref int firstCount, ref int secondCount)
    {
        int firsts = firstCount;
        int seconds = secondCount;
        firstCount = seconds;
        secondCount = firsts;
    }
    public static string ExchangeAndDescribe(int warehouseA, int warehouseB)
    {
        ExchangeCounts(ref warehouseA, ref warehouseB);
        return $"Warehouse A: {warehouseA}, Warehouse B: {warehouseB}";
    }
}