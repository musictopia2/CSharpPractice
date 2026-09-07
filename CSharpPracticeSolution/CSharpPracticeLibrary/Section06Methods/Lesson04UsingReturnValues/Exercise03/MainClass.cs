namespace CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise03;

public static class MainClass
{
    public static int GetItemsShipped(int orders, int itemsPerOrder)
    {
        return orders * itemsPerOrder;
    }

    public static int GetRemainingInventory(
        int startingInventory,
        int orders,
        int itemsPerOrder)
    {
        int shipped = GetItemsShipped(orders, itemsPerOrder);
        return startingInventory - shipped;
    }
}