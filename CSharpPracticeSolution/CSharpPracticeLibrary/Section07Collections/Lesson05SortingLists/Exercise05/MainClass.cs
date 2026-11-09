/*
Enter the requirements for this exercise here.
The client requires:
- Only payments greater than or equal to minimumAmount qualify.
- Select at most maximumCount qualifying payments.
- When largestFirst is true, select the largest qualifying payments first and return them in descending order.
- Otherwise, select the smallest qualifying payments first and return them in ascending order.
- Remove each selected payment from pendingPayments.
- Preserve the relative order of the payments remaining in the original list.
- Duplicates represent separate payments. Selecting two payments of the same amount removes exactly two occurrences. When choosing between equal amounts, remove the earliest occurrences in the backlog.
- Return a separate list containing the selected batch.
- If nothing qualifies or maximumCount is zero, return an empty list and leave the backlog unchanged.
- Negative amounts and minimums are valid. Assume the list is not null and maximumCount is not negative.
- Use Sort() and, when needed, Reverse() to order the batch.
Each example below starts with a fresh backlog:
Backlog	Minimum	Maximum	largestFirst	Returned batch	Remaining backlog
[40, 120, 75, 120, 30, 95]	70	3	true	[120, 120, 95]	[40, 75, 30]
[40, 120, 75, 120, 30, 95]	70	2	false	[75, 95]	[40, 120, 120, 30]
[90, 20, 90, 60]	50	1	true	[90]	[20, 90, 60]
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson05SortingLists.Exercise05;


public static  class MainClass
{
    public static List<int> BuildPaymentReviewBatch(
        List<int> pendingPayments,
        int minimumAmount,
        int maximumCount,
        bool largestFirst)
    {
        var lists = pendingPayments.Where(x => x >= minimumAmount).ToList();
        lists.Sort();
        if (largestFirst)
        {
            lists.Reverse();
        }
        var output = lists.Take(maximumCount).ToList();

        foreach (var item in output)
        {
            pendingPayments.Remove(item);
        }

        return output;

    }
}