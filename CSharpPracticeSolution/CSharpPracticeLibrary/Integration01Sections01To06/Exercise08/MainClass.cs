/*
Enter the requirements for this exercise here.
This mini-project tracks a monthly expense budget across several expense entries.

Create these public static methods.

1. Calculate total valid expenses
public static decimal CalculateTotalExpenses(
    List<decimal> expenses)

Only expenses greater than 0 count.

Return the total of all valid expenses.

2. Count expenses over a review limit
public static int CountExpensesOverLimit(
    List<decimal> expenses,
    decimal reviewLimit)

Count how many valid expenses are greater than reviewLimit.

Zero and negative values do not count.

3. Find the largest valid expense
public static decimal FindLargestExpense(
    List<decimal> expenses)

Return the largest expense greater than 0.

If there are no valid expenses, return 0.

4. Calculate remaining budget
public static decimal CalculateRemainingBudget(
    decimal monthlyBudget,
    decimal totalExpenses)

Return:

monthlyBudget - totalExpenses

The result is allowed to be negative if spending exceeded the budget.

5. Determine budget status
public static string GetBudgetStatus(
    decimal remainingBudget)

Return exactly one of these values:

remaining budget greater than 0 → "Under Budget"
remaining budget equal to 0 → "Budget Met"
remaining budget less than 0 → "Over Budget"
6. Create the monthly report
public static string CreateMonthlyBudgetReport(
    decimal monthlyBudget,
    List<decimal> expenses,
    decimal reviewLimit)

This method must use the other methods to create the report.

Return exactly this format:

Status: Under Budget | Expenses: $3,200.00 | Remaining: $800.00 | Over Limit: 2 | Largest: $1,500.00
*/

namespace CSharpPracticeLibrary.Integration01Sections01To06.Exercise08;
public static class MainClass
{
    public static decimal CalculateTotalExpenses(
    List<decimal> expenses)
    {
        return expenses.SumWhere(x => x > 0);
    }
    public static int CountExpensesOverLimit(
    List<decimal> expenses,
    decimal reviewLimit)
    {
        return expenses.Count(x => x > reviewLimit);
    }
    public static decimal FindLargestExpense(
    List<decimal> expenses)
    {
        if (expenses.Count == 0)
        {
            return 0;
        }
        return expenses.Max(x => x);
    }
    public static decimal CalculateRemainingBudget(
    decimal monthlyBudget,
    decimal totalExpenses)
    {
        return monthlyBudget - totalExpenses;
    }
    public static string GetBudgetStatus(
    decimal remainingBudget)
    {
        if (remainingBudget > 0)
        {
            return "Under Budget";
        }
        if (remainingBudget == 0)
        {
            return "Budget Met";
        }
        if (remainingBudget < 0)
        {
            return "Over Budget";
        }
        return "Unknown";
    }
    public static string CreateMonthlyBudgetReport(
    decimal monthlyBudget,
    List<decimal> expenses,
    decimal reviewLimit)
    {
        decimal totals = CalculateTotalExpenses(expenses);
        decimal remaining = CalculateRemainingBudget(monthlyBudget, totals);
        int overs = CountExpensesOverLimit(expenses, reviewLimit);
        decimal largest = FindLargestExpense(expenses);
        string status = GetBudgetStatus(remaining);
        return $"Status: {status} | Expenses: {totals.ToCurrency()} | Remaining: {remaining.ToCurrency()} | Over Limit: {overs} | Largest: {largest.ToCurrency()}";
    }
}