namespace CSharpPracticeLibrary.Section06Methods.Lesson04UsingReturnValues.Exercise01;
public static class MainClass
{
    public static int GetItemsPerShipment(int boxes, int itemsPerBox)
    {
        return boxes * itemsPerBox;
    }
    public static int GetTotalItems(int boxes, int itemsPerBox, int shipments)
    {
        int subs = GetItemsPerShipment(boxes, itemsPerBox);
        return subs * shipments;
    }
}