/*
Enter the requirements for this exercise here.
Requirements:
- Include only payments greater than or equal to minimumAmount.
- Return those payments in descending order.
- Return at most maximumCount payments.
- Preserve duplicates: equal amounts represent separate payments.
- Leave the original list unchanged.
- Return an empty list when no payments qualify or maximumCount is zero.
- Negative amounts and negative minimums are valid.
- Assume the list is not null and maximumCount is not negative.
- Use Sort() and Reverse() to arrange the selected payments.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson05SortingLists.Exercise04;


public static  class MainClass
{
    public static List<int> SelectPaymentsForReview(
    List<int> paymentAmounts,
    int minimumAmount,
    int maximumCount)
    {
        var lists = paymentAmounts.Where(x => x >= minimumAmount).ToList();
        lists.Sort();
        lists.Reverse();
        return lists.Take(maximumCount).ToList();
    }
}