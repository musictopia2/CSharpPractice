namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson08Review.Exercise04;
public static class MainClass
{
    public static string GetDeliveryStatus(
    int packageCount,
    bool isPriorityCustomer,
    bool paymentReceived)
    {
        if (packageCount is < 1)
        {
            return "Invalid Shipment";
        }
        if (paymentReceived == false)
        {
            return "Payment Required";
        }
        if (isPriorityCustomer)
        {
            if (packageCount is >= 20)
            {
                return "Priority Bulk";
            }
            else
            {
                return "Priority";
            }
        }
        if (packageCount is >= 20)
        {
            return "Bulk";
        }
        else
        {
            return "Standard";
        }
    }
}