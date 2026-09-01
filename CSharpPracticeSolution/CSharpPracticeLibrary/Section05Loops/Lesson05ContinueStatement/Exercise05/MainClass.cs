namespace CSharpPracticeLibrary.Section05Loops.Lesson05ContinueStatement.Exercise05;
public static class MainClass
{
    public static int CalculateShippedItems(List<int> shipmentQuantities)
    {
        int totals = 0;
        foreach (var item in shipmentQuantities)
        {
            if (item <= 0)
            {
                continue;
            }
            totals += item;
        }
        return totals;
    }
}