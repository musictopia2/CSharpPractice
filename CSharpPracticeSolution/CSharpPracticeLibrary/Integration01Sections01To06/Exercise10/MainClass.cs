/*
Enter the requirements for this exercise here.
Client requirement

An accounting department processes a batch of customer cash receipts.

For each receipt, the system is given:

the amount the customer paid
the amount that was expected for that receipt

The two lists correspond by position:

List<decimal> actualPayments
List<decimal> expectedPayments

The lists will always contain the same number of items.

The accounting department wants to know how well the batch reconciled.

For each receipt:

If the actual payment is less than 0, treat the receipt as invalid.
Invalid receipts do not contribute to any dollar totals and do not count as matched, short, or overpaid.
An actual payment of 0 is valid.
If actual payment equals expected payment, it is Matched.
If actual payment is less than expected payment, it is Short.
If actual payment is greater than expected payment, it is Overpaid.

The report must include:

total valid cash actually received
total expected cash for valid receipts
number of matched receipts
number of short receipts
number of overpaid receipts
total shortage amount
total overpayment amount

For a short receipt, only the difference contributes to the shortage total.

Example:

Expected = 500
Actual = 425

contributes:

75

to the shortage.

For an overpayment:

Expected = 300
Actual = 340

contributes:

40

to the overpayment total.

Example batch

Actual payments:

500.00
425.00
340.00
-25.00
0.00

Expected payments:

500.00
500.00
300.00
100.00
0.00

This produces:

Actual Received = 1,265.00
Expected = 1,300.00
Matched = 2
Short = 1
Overpaid = 1
Shortage = 75.00
Overpayment = 40.00

The negative receipt is ignored completely.

Return exactly:

Actual: $1,265.00 | Expected: $1,300.00 | Matched: 2 | Short: 1 | Overpaid: 1 | Shortage: $75.00 | Overpayment: $40.00

Use your existing ToCurrency() formatting.


Your design decision

The client is not specifying the internal method structure.

You decide:

whether to use one pass or several
how many helper methods are useful
whether individual calculations deserve their own methods
what state you need while processing the batch
how to avoid unnecessarily duplicating the comparison logic

The only required public entry point is:

public static string CreateCashReceiptReconciliation(
    List<decimal> actualPayments,
    List<decimal> expectedPayments)

*/

namespace CSharpPracticeLibrary.Integration01Sections01To06.Exercise10;
public static class MainClass
{
    private static PaymentDetails GetPaymentDetails(List<decimal> actualPayments,
    List<decimal> expectedPayments)
    {
        PaymentDetails output = new();
        actualPayments.Count.Times(x =>
        {
            decimal actualSingle = actualPayments[x - 1];
            if (actualSingle < 0)
            {
                return;
            }
            output.TotalActual += actualSingle;
            decimal expectedSingle = expectedPayments[x - 1];
            output.TotalExpected += expectedSingle;
            if (actualSingle == expectedSingle)
            {
                output.Matched++;
            }
            if (actualSingle > expectedSingle)
            {
                output.Overpaid++;
                output.Overpayment += actualSingle - expectedSingle;
            }
            if (actualSingle < expectedSingle)
            {
                output.Short++;
                
                output.Shortage += expectedSingle - actualSingle;
            }
        });
        return output;
    }

    public static string CreateCashReceiptReconciliation(
    List<decimal> actualPayments,
    List<decimal> expectedPayments)
    {
        PaymentDetails details = GetPaymentDetails(actualPayments, expectedPayments);
        return $"Actual: {details.TotalActual.ToCurrency()} | Expected: {details.TotalExpected.ToCurrency()} | Matched: {details.Matched} | Short: {details.Short} | Overpaid: {details.Overpaid} | Shortage: {details.Shortage.ToCurrency()} | Overpayment: {details.Overpayment.ToCurrency()}";
    }
}
