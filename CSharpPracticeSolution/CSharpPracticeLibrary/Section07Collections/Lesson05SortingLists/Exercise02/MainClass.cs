/*
Enter the requirements for this exercise here.
Requirements:
- Use Reverse() to reverse the supplied list’s current order.
- Modify the original list and return that same list.
- Preserve every value, including duplicates.
- Empty lists and lists containing one item should remain unchanged.
- Assume the supplied list is not null.
Example:
Input:  [430, 120, 780, 250]
Result: [250, 780, 120, 430]
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson05SortingLists.Exercise02;


public static  class MainClass
{
    public static List<int> ReverseReviewQueue(List<int> accountNumbers)
    {
        accountNumbers.Reverse();
        return accountNumbers;
    }
}