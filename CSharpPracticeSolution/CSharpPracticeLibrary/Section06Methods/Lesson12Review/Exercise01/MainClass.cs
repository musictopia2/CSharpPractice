/*
Enter the requirements for this exercise here.
A warehouse needs methods for calculating and reporting how an order will be packed.

1. Create a public static method named CalculateTotalItems.

   - It receives any number of integer item quantities using a params parameter.
   - Use a List<int> params collection.
   - Return the total of all quantities.
   - If no quantities are supplied, return 0.

2. Create a public static method named CalculatePackingDetails.

   Parameters:
   - int totalItems
   - int boxCapacity
   - out int completeBoxes
   - out int remainingItems

   Requirements:
   - If totalItems is negative or boxCapacity is less than or equal to 0:
       - set completeBoxes to 0
       - set remainingItems to 0
       - return false
   - Otherwise:
       - calculate how many completely filled boxes can be made
       - calculate how many items remain
       - place those values in the out parameters
       - return true

3. Create a public static method named CreatePackingMessage.

   Parameters:
   - int completeBoxes
   - int remainingItems
   - string label = "Packing"

   Return exactly:

   "{label}: {completeBoxes} complete boxes, {remainingItems} remaining items"

   Example:

   CreatePackingMessage(4, 3)

   returns:

   "Packing: 4 complete boxes, 3 remaining items"

   CreatePackingMessage(2, 1, "Order")

   returns:

   "Order: 2 complete boxes, 1 remaining items"
*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise01;
public static class MainClass
{
    public static int CalculateTotalItems(params List<int> list)
    {
        return list.Sum();
    }

    public static bool CalculatePackingDetails(in int totalItems,
        in int boxCapacity,
        out int completeBoxes,
        out int remainingItems)
    {
        if (totalItems < 0 || boxCapacity <= 0)
        {
            completeBoxes = 0;
            remainingItems = 0;
            return false;
        }
        completeBoxes = totalItems / boxCapacity;
        remainingItems = totalItems.Remainder(boxCapacity);
        return true;
    }
    public static string CreatePackingMessage(int completeBoxes, int remainingItems)
    {
        return CreatePackingMessage(completeBoxes, remainingItems, "Packing");
    }
    public static string CreatePackingMessage(int completeBoxes, int remainingItems, string label)
    {
        return $"{label}: {completeBoxes} complete boxes, {remainingItems} remaining items";
        
    }
}