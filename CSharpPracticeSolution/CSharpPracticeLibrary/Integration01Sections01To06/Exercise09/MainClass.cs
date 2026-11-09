/*
Enter the requirements for this exercise here.
A small business wants a simple account-review tool for customer balances.

For each customer account, the business supplies:

the current account balance
the customer's credit limit

The tool receives two lists:

List<decimal> accountBalances
List<decimal> creditLimits

The item at each position in one list belongs to the item at the same position in the other list.

The two lists will always contain the same number of items.

The client wants one summary report for the full set of customer accounts.

The report must include:

the total of all positive customer balances
how many customers currently owe money
how many customers are over their credit limit
the total amount by which customers exceed their credit limits

A customer is over the credit limit only when:

account balance > credit limit

For a customer who is over the limit, only the amount above the limit contributes to the total over-limit amount.

For example:

Balance = 1,200
Credit Limit = 1,000

contributes:

200

to the over-limit total.

Zero or negative account balances represent customers who do not currently owe money. They do not count toward the balance total or customer count, and they cannot be over the credit limit.

Example

Balances:

500.00
1200.00
0.00
-100.00
750.00

Credit limits:

1000.00
1000.00
500.00
500.00
500.00

The results are:

Total balances owed = 2450.00
Customers owing = 3
Customers over limit = 2
Total over limit = 450.00

Return the final report exactly like this:

Balances Owed: $2,450.00 | Customers Owing: 3 | Over Limit: 2 | Amount Over Limit: $450.00

Use your existing ToCurrency() formatting.

Your design decision

The client only cares that the report is correct.

You decide:

how many methods are appropriate
what those methods are named
what calculations belong together
whether some behavior should be reusable
whether you process everything in one pass or several passes

The only required public entry point is:

public static string CreateCustomerAccountReport(
    List<decimal> accountBalances,
    List<decimal> creditLimits)
*/

namespace CSharpPracticeLibrary.Integration01Sections01To06.Exercise09;
public static class MainClass
{
    public static void GetOtherDetails(List<decimal> accountBalances,
    List<decimal> creditLimits,
    out int howManyOverLimits, out decimal overlimitAmount
    )
    {
        //will assume the list counts match.
        int tempOver = 0;
        decimal amount = 0;
        accountBalances.Count.Times(x =>
        {
            decimal balance = accountBalances[x - 1];
            decimal limit = creditLimits[x - 1];
            if (balance > limit)
            {
                tempOver++;
                decimal diffs = balance - limit;
                amount += diffs;
            }
        });
        howManyOverLimits = tempOver;
        overlimitAmount = amount;
    }
    public static string CreateCustomerAccountReport(
    List<decimal> accountBalances,
    List<decimal> creditLimits)
    {
        decimal totals = accountBalances.SumWhere(x => x > 0);
        int owing = accountBalances.Count(x => x > 0);
        GetOtherDetails(accountBalances, creditLimits, out int overCount, out decimal overAmount);
        return $"Balances Owed: {totals.ToCurrency()} | Customers Owing: {owing} | Over Limit: {overCount} | Amount Over Limit: {overAmount.ToCurrency()}";
    }
}