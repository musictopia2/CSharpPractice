namespace CSharpPracticeLibrary.Section06Methods.Lesson09RefParameters.Exercise05;
public static class MainClass
{
    public static void ApplyInventoryCorrection(
    ref int inventoryCount,
    int correction)
    {
        if (correction == 0)
        {
            return;
        }
        if (correction > 0)
        {
            inventoryCount += correction;
        }
        else
        {
            inventoryCount += correction;
        }
    }
    public static void ReconcileInventory(
    ref int warehouseCount,
    ref int reservedCount,
    int warehouseCorrection,
    int reservedCorrection)
    {
        ApplyInventoryCorrection(ref warehouseCount, warehouseCorrection);
        ApplyInventoryCorrection(ref reservedCount, reservedCorrection);
    }
}
/*
The client defines correction as the amount that should be added to the current inventory count.

Therefore:

A positive correction increases inventory.
A negative correction decreases inventory.
A correction of zero leaves inventory unchanged.
The caller's original inventoryCount variable must contain the corrected value after the method returns.

For example, an inventory of 120 with a correction of -15 should become 105.

Additional requirement

Create:

public static void ReconcileInventory(
ref int warehouseCount,
ref int reservedCount,
int warehouseCorrection,
int reservedCorrection)

This method must use your ApplyInventoryCorrection method to apply the appropriate correction to each original variable.

The purpose of that requirement is important: Exercise 05 isn't just about changing ref variables again. It tests whether you can pass a ref parameter along to another method that also expects ref.
*/