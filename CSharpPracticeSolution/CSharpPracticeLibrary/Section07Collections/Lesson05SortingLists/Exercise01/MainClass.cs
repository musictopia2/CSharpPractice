/*
Enter the requirements for this exercise here.
Requirements:
- Use Sort() to arrange the supplied list in ascending order.
- Modify the original list and return that same list.
- Preserve duplicate values.
- An empty list should remain empty.
- Assume the supplied list is not null.
Example:
Input:  [730, 215, 480, 215]
Result: [215, 215, 480, 730]
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson05SortingLists.Exercise01;


public static  class MainClass
{
    public static List<int> ArrangeInvoiceNumbers(List<int> invoiceNumbers)
    {
        invoiceNumbers.Sort();
        return invoiceNumbers;
    }
}