/*
Enter the requirements for this exercise here.
Requirements

A warehouse keeps its orders in processing order. The client wants to know whether a particular order exists and, if so, whether it appears early enough to receive priority processing.

Your method must use Contains() and IndexOf().

If orderNumber does not exist in orderNumbers, return exactly:

Order not found

If the order exists, use the index of its first occurrence.

An order receives priority processing when its index is less than priorityCutoff.

Return exactly:

Priority order at index X

or:

Standard order at index X

where X is the first index of the order.

For example, if:

List<int> orderNumbers =
[
    410,
    275,
    830,
    625,
    190
];

and priorityCutoff is 3, orders at indexes 0, 1, and 2 are priority orders, while indexes 3 and above are standard orders.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise04;
public static class MainClass
{
    public static string CheckPriorityOrder(
    List<int> orderNumbers,
    int orderNumber,
    int priorityCutoff)
    {
        if (orderNumbers.Contains(orderNumber) == false)
        {
            return "Order not found";
        }
        int index = orderNumbers.IndexOf(orderNumber);
        if (index < priorityCutoff)
        {
            return $"Priority order at index {index}";
        }
        return $"Standard order at index {index}";
    }
}