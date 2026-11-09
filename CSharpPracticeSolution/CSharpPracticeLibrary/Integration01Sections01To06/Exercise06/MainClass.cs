/*
Enter the requirements for this exercise here.
Create these public static methods:

CalculateApprovedExpenses

Receives:

List<decimal> expenses
decimal maximumSingleExpense

Returns the total of approved expenses.

An expense is approved only when:

it is greater than 0
it is less than or equal to maximumSingleExpense

Invalid or over-limit expenses are not included in the approved total.

CountRejectedExpenses

Receives:

List<decimal> expenses
decimal maximumSingleExpense

Returns how many expenses are rejected.

An expense is rejected when:

it is less than or equal to 0
or it is greater than maximumSingleExpense
CalculateReimbursement

Receives:

decimal approvedExpenses
decimal reimbursementPercent

Return the amount that will actually be reimbursed.

For example, if approved expenses total 800.00 and the reimbursement percentage is 75, return:

600.00

If reimbursementPercent is below 0, use 0%.

If it is above 100, use 100%.

CreateReimbursementSummary

Receives:

List<decimal> expenses
decimal maximumSingleExpense
decimal reimbursementPercent

This method must call the other three methods and return exactly:

Approved: $800.00 | Rejected: 2 | Reimbursement: $600.00

Use your existing ToCurrency() formatting.

Example

Expenses:

250.00
-20.00
500.00
900.00
50.00

Maximum single expense:

500.00

Reimbursement percentage:

80

Approved expenses are:

250.00
500.00
50.00

So:

Approved total = 800.00
Rejected count = 2
Reimbursement = 640.00

Return:

Approved: $800.00 | Rejected: 2 | Reimbursement: $640.00

The important difference from Exercise 05 is that multiple methods now apply different business rules to the same collection, and the final method coordinates all of them.
*/

namespace CSharpPracticeLibrary.Integration01Sections01To06.Exercise06;
public static class MainClass
{
    public static decimal CalculateApprovedExpenses(List<decimal> expenses, decimal maximumSingleExpense)
    {
        return expenses.SumWhere(x => x > 0 && x <= maximumSingleExpense);
    }
    public static int CountRejectedExpenses(List<decimal> expenses, decimal maximumSingleExpense)
    {
        return expenses.Count(x => x <= 0 || x > maximumSingleExpense);
    }
    public static decimal CalculateReimbursement(decimal approvedExpense, decimal reimbursementPercent)
    {
        decimal realPercent = reimbursementPercent.Percentage;
        return approvedExpense * realPercent / 100;
    }
    public static string CreateReimbursementSummary(List<decimal> expenses, 
        decimal maximumSingleExpense, decimal reimbursementPercent)
    {

        decimal approved = CalculateApprovedExpenses(expenses, maximumSingleExpense);
        int rejected = CountRejectedExpenses(expenses, maximumSingleExpense);
        decimal reimbursementTotal = CalculateReimbursement(approved, reimbursementPercent);
        return $"Approved: {approved.ToCurrency()} | Rejected: {rejected} | Reimbursement: {reimbursementTotal.ToCurrency()}";
    }
}