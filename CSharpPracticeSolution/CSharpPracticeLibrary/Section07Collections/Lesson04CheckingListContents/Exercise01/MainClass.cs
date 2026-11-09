/*
Enter the requirements for this exercise here.
Requirements

The method receives a list of inventory item names and an item to search for.

You must:

Use Contains() to determine whether itemToFind exists in inventoryItems.
If it does not exist, return exactly:
Item not found
If it does exist, use IndexOf() to find its first position in the list.
Return:
Item found at index X

where X is the zero-based index.

For example, if the item is first found at index 2, the result must be:

Item found at index 2

The search should use the normal behavior of List<string>.Contains() and IndexOf(); you do not need to add case-insensitive searching or other special handling.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise01;
public static class MainClass
{
    public static string LocateItem(List<string> inventoryItems, string itemToFind)
    {
        if (inventoryItems.Contains(itemToFind) == false)
        {
            return "Item not found";
        }
        int index = inventoryItems.IndexOf(itemToFind);
        return $"Item found at index {index}";
    }
}