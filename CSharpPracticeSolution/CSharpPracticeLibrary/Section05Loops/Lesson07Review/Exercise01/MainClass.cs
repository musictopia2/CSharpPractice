namespace CSharpPracticeLibrary.Section05Loops.Lesson07Review.Exercise01;
public static class MainClass
{
    public static int CountAcceptedShipments(List<int> shipmentSizes)
    {
        int accepted = 0;
        foreach (var item in shipmentSizes)
        {
            if (item == 0)
            {
                continue;
            }
            if (item.Remainder(5) == 0)
            {
                accepted++;
            }
        }
        return accepted;
    }
}