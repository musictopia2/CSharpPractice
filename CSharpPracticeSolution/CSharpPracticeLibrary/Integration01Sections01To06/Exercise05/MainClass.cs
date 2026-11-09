/*
Enter the requirements for this exercise here.
This exercise should use several methods that cooperate instead of putting the whole requirement into one method.

Requirement

The accounting department receives an invoice amount and a list of payments that have been posted against that invoice.

Create these three public static methods:

CalculateTotalPayments

Receives:

List<decimal> payments

Returns the total of all positive payments.

Zero and negative values are ignored.

CalculateRemainingBalance

Receives:

decimal invoiceAmount
decimal totalPayments

Returns:

invoiceAmount - totalPayments

The remaining balance is allowed to be negative if the customer overpaid.

CreatePaymentStatus

Receives:

decimal invoiceAmount
List<decimal> payments

This method must use the other methods to calculate the result.

Return exactly one of these formats:

If money is still owed:

Status: Balance Due | Paid: $600.00 | Remaining: $400.00

If the invoice is paid exactly:

Status: Paid | Paid: $1,000.00 | Remaining: $0.00

If the customer has overpaid:

Status: Overpaid | Paid: $1,200.00 | Remaining: $-200.00

Use your normal ToCurrency() formatting.

Example

Invoice amount:

1000.00

Payments:

300.00
-25.00
0.00
250.00
150.00

Only the positive payments count, so:

Total payments = 700.00
Remaining balance = 300.00

The returned string is:

Status: Balance Due | Paid: $700.00 | Remaining: $300.00
Important details

CreatePaymentStatus should call CalculateTotalPayments and CalculateRemainingBalance rather than duplicate their calculations.

Status is determined from the remaining balance:

greater than 0 → Balance Due
equal to 0 → Paid
less than 0 → Overpaid
*/

namespace CSharpPracticeLibrary.Integration01Sections01To06.Exercise05;
public static class MainClass
{
    public static decimal CalculateTotalPayments(List<decimal> payments)
    {
        return payments.SumWhere(x => x > 0);
    }
    public static decimal CalculateRemainingBalance(decimal invoiceAmount, decimal totalPayments)
    {
        return invoiceAmount - totalPayments;
    }
    public static string CreatePaymentStatus(decimal invoiceAmount, List<decimal> payments)
    {
        decimal totalPayments = CalculateTotalPayments(payments);
        decimal remainingBalance = CalculateRemainingBalance(invoiceAmount, totalPayments);
        string paymentString = $"Paid: {totalPayments.ToCurrency()}";
        string remaining = $"Remaining: {remainingBalance.ToCurrency()}";
        string status;
        if (remainingBalance == 0)
        {
            status = "Paid";
            //return "Status: Paid | Paid: $1,000.00 | Remaining: $0.00";
        }
        else if (remainingBalance < 0)
        {
            status = "Overpaid";
        }
        else
        {
            status = "Balance Due";
        }
        return $"Status: {status} | {paymentString} | {remaining}";
    }

}