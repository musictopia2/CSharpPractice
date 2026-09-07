namespace CSharpPracticeLibrary.Section06Methods.Lesson09RefParameters.Exercise02;
public static class MainClass
{
    public static void TransferItems(
    ref int sourceQuantity,
    ref int destinationQuantity,
    int amount)
    {
        int tempSource = sourceQuantity;
        int tempDestination = destinationQuantity;
        sourceQuantity = tempSource - amount;
        destinationQuantity = tempDestination + amount;
    }
}