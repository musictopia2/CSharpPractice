namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson03ElseIfChains.Exercise04;
public static class MainClass
{
    public static string GetDeliveryStatus(
    int availableItems,
    int requestedItems,
    bool paymentReceived,
    bool addressVerified)
    {
        if (requestedItems > availableItems)
        {
            return "Insufficient Stock";
        }
        else if (paymentReceived == false)
        {
            return "Payment Required";
        }
        else if (addressVerified == false)
        {
            return "Address Verification Required";
        }
        else
        {
            return "Ready for Delivery";
        }
    }
}