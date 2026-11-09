/*
Enter the requirements for this exercise here.
Client Requirement

An accounting client keeps invoice amounts in a list. One invoice is selected for review by its index.

The client wants the selected invoice removed only when its amount is outside the allowed range.

Your method must:

Get the invoice amount at reviewIndex.
If the amount is less than minimumAllowed or greater than maximumAllowed:
remove that invoice using RemoveAt();
return:
Invoice removed
Otherwise:
leave the list unchanged;
return:
Invoice accepted
An amount exactly equal to either boundary is valid.
Only the invoice at reviewIndex may be evaluated.
Other invalid-looking invoice amounts in the list must remain untouched.
You may assume reviewIndex is valid.
Example

Given:

invoiceAmounts = [125.00, 20.00, 450.00, 900.00]
reviewIndex = 2
minimumAllowed = 50.00
maximumAllowed = 500.00

The selected invoice is 450.00, so the method returns:

Invoice accepted

and the list remains unchanged.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise05;
public static class MainClass
{
    public static string ReviewInvoice(
    List<decimal> invoiceAmounts,
    int reviewIndex,
    decimal minimumAllowed,
    decimal maximumAllowed)
    {
        decimal possibleItem = invoiceAmounts[reviewIndex];
        if (possibleItem < minimumAllowed || possibleItem > maximumAllowed)
        {
            invoiceAmounts.RemoveAt(reviewIndex);
            return "Invoice removed";
        }
        return "Invoice accepted";
    }
}