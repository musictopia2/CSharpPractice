namespace CSharpPracticeLibrary.Section03Operators.Lesson13Review.Exercise05;
public static class MainClass
{
    public static bool CanApproveDelivery(
    int availableItems,
    int requestedItems,
    int itemsPerBox,
    bool paymentReceived,
    bool addressVerified,
    bool priorityCustomer)
    {
        bool hasEnoughItems = requestedItems <= availableItems;
        int leftOvers = requestedItems.Remainder(itemsPerBox);
        bool paymentRequirement = priorityCustomer || paymentReceived;
        return hasEnoughItems && leftOvers == 0 && paymentRequirement && addressVerified;
    }
}