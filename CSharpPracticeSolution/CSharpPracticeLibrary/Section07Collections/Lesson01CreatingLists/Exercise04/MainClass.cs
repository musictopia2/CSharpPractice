/*
Enter the requirements for this exercise here.
public static void PrintLargeOrders()
Requirements

Create a List<int> containing these order quantities, in this order:

12
35
8
50
21

Process the items in the list and print only quantities that are at least 20.

Keep them in their original order.

The exact output must be:

35
50
21

Your implementation must use the List<int> when determining what gets printed. Do not simply write the three expected values directly to the console.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson01CreatingLists.Exercise04;
public static class MainClass
{
    public static void PrintLargeOrders()
    {
        List<int> orders =
            [
            12, 35, 8, 50, 21
            ];
        orders.ForConditionalItems(x => x is >= 20, Console.WriteLine);
    }
}