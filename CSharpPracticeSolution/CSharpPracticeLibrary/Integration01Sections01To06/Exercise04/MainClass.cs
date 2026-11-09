/*
Enter the requirements for this exercise here.
Requirement

Create a public static method named:

CreateAccountActivitySummary

It receives:

decimal startingBalance
List<decimal> transactions

Each transaction must be processed in the order it appears in the list.

A positive transaction increases the balance. A negative transaction decreases the balance. Zero leaves the balance unchanged.

While processing the transactions, count how many times the account balance becomes negative immediately after a transaction is processed.

Return exactly:

Ending Balance: $450.00 | Negative Balances: 2
Example

Given a starting balance of:

100.00

and these transactions in this order:

-150.00
25.00
100.00
-50.00

the running balances are:

-50.00
-25.00
75.00
25.00

Therefore, return:

Ending Balance: $25.00 | Negative Balances: 2
Important details

The starting balance itself does not count as a negative balance occurrence. Only balances produced after processing transactions count.

If the balance remains negative through several transactions, each transaction that results in a negative balance counts.

For example, starting at 50 with transactions -100, 10, 20 produces balances of -50, -40, and -20, so Negative Balances is 3.

If there are no transactions, return the starting balance and 0 negative balances.

Use normal currency formatting for the ending balance.

Integration goal

This deliberately brings together the material from Sections 01–06: values and strings, arithmetic, comparisons/control flow, sequential processing, and a method with parameters and a return value.

Most importantly, unlike Exercise 03, you cannot determine Negative Balances by independently counting the transaction values. You need the running state of the account as each transaction is processed.
*/


namespace CSharpPracticeLibrary.Integration01Sections01To06.Exercise04;
public static class MainClass
{
    public static string CreateAccountActivitySummary(decimal startingBalance, List<decimal> transactions)
    {
        int negativeInstances = 0;
        decimal total = startingBalance;
        foreach (var item in transactions)
        {
            total += item;
            if (total < 0)
            {
                negativeInstances++;
            }
        }
        return $"Ending Balance: {total.ToCurrency()} | Negative Balances: {negativeInstances}";
    }
}