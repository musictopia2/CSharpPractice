/*
Enter the requirements for this exercise here.
Requirements:
- When largestFirst is false, arrange the amounts from smallest to largest.
- When largestFirst is true, arrange the amounts from largest to smallest.
- Use Sort() and, when needed, Reverse().
- Modify the original list and return that same list.
- Preserve duplicates. Negative amounts and zero are valid.
- Empty lists and lists containing one item should remain unchanged.
- Assume the supplied list is not null.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson05SortingLists.Exercise03;


public static  class MainClass
{
    public static List<int> ArrangeTransactionAmounts(
        List<int> amounts,
        bool largestFirst)
    {
        amounts.Sort();
        if (largestFirst)
        {
            amounts.Reverse();
        }
        return amounts;
    }
}