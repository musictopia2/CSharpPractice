/*
Enter the requirements for this exercise here.
Client requirements:

1. Create a public static method named CalculateOrderTotal.

   Parameters:
   - decimal pricePerItem
   - params List<int> quantities

   Requirements:
   - Add all quantities together.
   - Multiply the total quantity by pricePerItem.
   - Return the decimal result.
   - If no quantities are supplied, return 0.

2. Create a public static method named TryAddItems.

   Parameters:
   - ref int currentItemCount
   - int itemsToAdd
   - int maximumItems

   Requirements:
   - If itemsToAdd is negative, do not change currentItemCount
     and return false.
   - If adding itemsToAdd would make currentItemCount greater than
     maximumItems, do not change currentItemCount and return false.
   - Otherwise, update currentItemCount and return true.

3. Create a public static method named GetOrderStatus.

   Parameters:
   - in int currentItemCount
   - int minimumItems

   Requirements:
   - Return "Ready" when currentItemCount is greater than or equal
     to minimumItems.
   - Otherwise return "Waiting".

4. Create a public static method named CreateOrderSummary.

   Parameters:
   - int itemCount
   - decimal orderTotal
   - string customerType = "Standard"

   Requirements:
   - customerType MUST be an optional parameter.
   - Return exactly:

     "{customerType} order: {itemCount} items totaling {orderTotal:C}"

   Example:

   CreateOrderSummary(5, 25.00m)

   returns:

   "Standard order: 5 items totaling $25.00"

   Calling it with customerType: "Priority" would return:

   "Priority order: 5 items totaling $25.00"

5. The client wants these methods to remain separate.

   Do not combine all of the behavior into one large method.
*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise05;
public static class MainClass
{
    public static decimal CalculateOrderTotal(decimal pricePerItem,
        params List<int> quantities
        )
    {
        int totals = quantities.Sum();
        return totals * pricePerItem;
    }
    public static bool TryAddItems(ref int currentItemCount,
        int itemsToAdd,
        int maximumItems
        )
    {
        if (itemsToAdd < 0)
        {
            return false;
        }
        if (currentItemCount + itemsToAdd > maximumItems)
        {
            return false;
        }
        currentItemCount += itemsToAdd;
        return true;
    }
    public static string GetOrderStatus(int currentItemCount,
        int minimumItems
        )
    {
        if (currentItemCount >= minimumItems)
        {
            return "Ready";
        }
        return "Waiting";
    }
    public static string CreateOrderSummary(int itemCount,
        decimal orderTotal,
        string customerType = "Standard"
        )
    {
        return $"{customerType} order: {itemCount} items totaling {orderTotal.ToCurrency()}";
    }
}