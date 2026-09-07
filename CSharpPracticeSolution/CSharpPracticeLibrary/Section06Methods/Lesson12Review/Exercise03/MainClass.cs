/*
Enter the requirements for this exercise here.
A warehouse system needs to determine how much inventory should be reordered
and display the result.

1. Create a public static method named CalculateReorderAmount.

   Parameters:
   - int currentStock
   - int minimumStock
   - int targetStock

   Requirements:
   - If currentStock is greater than or equal to minimumStock, return 0.
   - Otherwise, return the number of items needed to bring currentStock
     up to targetStock.

2. Create a public static method named CreateReorderMessage.

   Parameters:
   - int currentStock
   - int minimumStock
   - int targetStock

   Requirements:
   - Call CalculateReorderAmount and use its returned value.
   - If the reorder amount is 0, return exactly:

     "No reorder needed"

   - Otherwise, return exactly:

     "Reorder {amount} items"

     where {amount} is the value returned from CalculateReorderAmount.

3. Create a public static void method named DisplayReorderMessage.

   Parameters:
   - int currentStock
   - int minimumStock
   - int targetStock

   Requirements:
   - Call CreateReorderMessage.
   - Use Console.WriteLine to display the returned message.
*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise03;
public static class MainClass
{
    public static int CalculateReorderAmount(int currentStock,
        int minimumStock,
        int targetStock
        )
    {
        if (currentStock >= minimumStock)
        {
            return 0;
        }
        return targetStock - currentStock;
    }
    public static string CreateReorderMessage(int currentStock,
        int minimumStock,
        int targetStock
        )
    {
        int amount = CalculateReorderAmount(currentStock, minimumStock, targetStock);
        if (amount == 0)
        {
            return "No reorder needed";
        }
        return $"Reorder {amount} items";
    }
    public static void DisplayReorderMessage(int currentStock,
        int minimumStock,
        int targetStock
        )
    {
        string message = CreateReorderMessage(currentStock, minimumStock, targetStock);
        Console.WriteLine(message);
    }
}