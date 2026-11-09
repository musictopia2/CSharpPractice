/*
Enter the requirements for this exercise here.
Type: Mini-project
Scenario: Accounting — Accounts Receivable Aging Review

This is the first mini-project, so there are several related behaviors to implement and eventually more test cases than the earlier exercises.

Use:

namespace CSharpPracticeLibrary.Integration01Sections01To06.Exercise07;

Create a MainClass.

Business requirement

An accounting department wants a small tool for reviewing outstanding customer invoices. Each invoice is represented by two values at the same position in two lists:

invoiceBalances — the unpaid balance
daysOutstanding — how many days the invoice has been outstanding

For example, index 0 in both lists describes the same invoice.

For this exercise, the two lists will always contain the same number of items.

1. Calculate total receivables

Create:

public static decimal CalculateTotalReceivables(
    List<decimal> invoiceBalances)

Only balances greater than 0 are outstanding receivables.

Return their total.

2. Count overdue invoices

Create:

public static int CountOverdueInvoices(
    List<decimal> invoiceBalances,
    List<int> daysOutstanding)

An invoice counts as overdue when:

its balance is greater than 0, and
it has been outstanding for more than 30 days.

A zero or negative balance never counts as overdue.

3. Calculate overdue receivables

Create:

public static decimal CalculateOverdueReceivables(
    List<decimal> invoiceBalances,
    List<int> daysOutstanding)

Return the total outstanding balance of invoices that meet the same overdue rule.

4. Find the oldest unpaid invoice

Create:

public static int FindOldestUnpaidInvoiceDays(
    List<decimal> invoiceBalances,
    List<int> daysOutstanding)

Return the greatest daysOutstanding value belonging to an invoice whose balance is greater than 0.

If there are no unpaid invoices, return 0.

5. Create the complete report

Create:

public static string CreateAccountsReceivableReport(
    List<decimal> invoiceBalances,
    List<int> daysOutstanding)

This method must use the other methods to produce the report.

Return exactly this format:

Total Receivables: $1,250.00 | Overdue Invoices: 2 | Overdue Receivables: $750.00 | Oldest Unpaid: 75 days

Use your existing ToCurrency() formatting.

Example

Suppose the balances are:

500.00
250.00
0.00
-50.00
400.00

and the corresponding days outstanding are:

15
45
90
120
75

The results are:

Total receivables = 1,150.00
Overdue invoices = 2
Overdue receivables = 650.00
Oldest unpaid invoice = 75 days

Therefore:

Total Receivables: $1,150.00 | Overdue Invoices: 2 | Overdue Receivables: $650.00 | Oldest Unpaid: 75 days

Notice that the 0.00 invoice at 90 days and the -50.00 invoice at 120 days do not affect the overdue or oldest-unpaid results because they aren't unpaid positive balances.

This one gives your SumWhere, LINQ knowledge, and other helpers room to be useful, but you'll also have to coordinate two related collections and several different accounting behaviors.
*/

namespace CSharpPracticeLibrary.Integration01Sections01To06.Exercise07;
public static class MainClass
{
    public static decimal CalculateTotalReceivables(
    List<decimal> invoiceBalances)
    {
        return invoiceBalances.SumWhere(x => x > 0);
    }
    public static int CountOverdueInvoices(
    List<decimal> invoiceBalances,
    List<int> daysOutstanding)
    {
        if (invoiceBalances.Count != daysOutstanding.Count)
        {
            return 0; //must match.
        }
        int count = 0;
        invoiceBalances.Count.Times(x =>
        {
            decimal balance = invoiceBalances[x - 1];
            int days = daysOutstanding[x - 1];
            if (balance > 0 && days > 30)
            {
                count++;
            }
        });
        return count;

    }
    public static decimal CalculateOverdueReceivables(
    List<decimal> invoiceBalances,
    List<int> daysOutstanding)
    {
        if (invoiceBalances.Count != daysOutstanding.Count)
        {
            return 0; //must match.
        }
        decimal sums = 0;
        invoiceBalances.Count.Times(x =>
        {
            decimal balance = invoiceBalances[x - 1];
            int days = daysOutstanding[x - 1];
            if (balance > 0 && days > 30)
            {
                sums += balance;
            }
        });
        return sums;
    }
    public static int FindOldestUnpaidInvoiceDays(
    List<decimal> invoiceBalances,
    List<int> daysOutstanding)
    {
        if (invoiceBalances.Count != daysOutstanding.Count)
        {
            return 0; //must match.
        }
        int oldest = 0;
        invoiceBalances.Count.Times(x =>
        {
            decimal balance = invoiceBalances[x - 1];
            int days = daysOutstanding[x - 1];
            if (balance > 0 && days > oldest)
            {
                oldest = days;
            }
        });
        return oldest;
    }
    public static string CreateAccountsReceivableReport(
    List<decimal> invoiceBalances,
    List<int> daysOutstanding)
    {
        int overdueCount = CountOverdueInvoices(invoiceBalances, daysOutstanding);
        decimal overdueAmount = CalculateOverdueReceivables(invoiceBalances, daysOutstanding);
        int oldest = FindOldestUnpaidInvoiceDays(invoiceBalances, daysOutstanding);
        decimal totals = CalculateTotalReceivables(invoiceBalances);
        return $"Total Receivables: {totals.ToCurrency()} | Overdue Invoices: {overdueCount} | Overdue Receivables: {overdueAmount.ToCurrency()} | Oldest Unpaid: {oldest} days";
    }
}