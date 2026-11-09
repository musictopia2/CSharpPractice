/*
Enter the requirements for this exercise here.
Create a public static method named:

CreateInvoiceBatchSummary

It receives:

List<decimal> invoiceAmounts
decimal reviewThreshold

It returns a string.

The method must examine every invoice amount and produce one summary string.

For each invoice:

If the amount is less than 0, treat it as invalid and do not include it in any totals.
If the amount is 0, count it as a zero-value invoice.
If the amount is greater than 0, include it in the valid invoice total.
If the amount is greater than or equal to reviewThreshold, also count it as requiring review.

After all invoices have been processed, return exactly this format:

Valid Total: $750.00 | Invalid: 1 | Zero: 1 | Review: 2

Use normal currency formatting for the valid total.

Example

Given:

Invoice amounts:
250.00
-40.00
0.00
500.00
75.00

Review threshold:
200.00

The result is:

Valid Total: $825.00 | Invalid: 1 | Zero: 1 | Review: 2
Important details

A zero-value invoice is not invalid and is not included in the valid total.

Only positive invoice amounts can count toward Review.

If invoiceAmounts is empty, return:

Valid Total: $0.00 | Invalid: 0 | Zero: 0 | Review: 0

This one is intentionally harder to collapse into one simple LINQ operation. You can still use LINQ where it makes sense, but the requirement naturally involves several categories, conditions, accumulated values, looping/iteration, method logic, operators, types, and exact string output.
*/

namespace CSharpPracticeLibrary.Integration01Sections01To06.Exercise03;
public static class MainClass
{
    public static string CreateInvoiceBatchSummary(List<decimal> invoiceAmounts, decimal reviewThreshold)
    {
        //decimal totals = invoiceAmounts.Sum(x => x >= reviewThreshold);

        decimal totals = 0;
        int reviews = 0;
        int invalids = 0;
        int zeros = 0;
        zeros = invoiceAmounts.Count(x => x == 0);
        invalids = invoiceAmounts.Count(x => x < 0);
        reviews = invoiceAmounts.Count(x => x >= reviewThreshold && x > 0);
        totals = invoiceAmounts.SumWhere(x => x > 0);
        //totals = invoiceAmounts.SumWhere(x => x > reviewThreshold);
        return $"Valid Total: {totals.ToCurrency()} | Invalid: {invalids} | Zero: {zeros} | Review: {reviews}";

    }
}