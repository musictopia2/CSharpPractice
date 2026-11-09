/*
Enter the requirements for this exercise here.
Create a public static method named:

CalculateEndingBalance

It receives:

a decimal startingBalance
a List<decimal> transactions

Each value in transactions represents activity posted to the account:

A positive value increases the account balance.
A negative value decreases the account balance.
A value of 0 has no effect.

Process every transaction and return the final account balance.

Examples

Starting balance:

1000.00

Transactions:

250.00
-100.00
75.50

The returned ending balance is:

1225.50

Another example:

Starting balance:

500.00

Transactions:

-125.00
-50.00
200.00

The returned ending balance is:

525.00

An empty transaction list simply returns the original starting balance.

Integration goal

This exercise intentionally focuses on four sections:

Basic Types: decimal and List<decimal>
Operators: updating a balance with positive and negative values
Loops: processing every transaction
Methods: receiving the information and returning the calculated result
*/

namespace CSharpPracticeLibrary.Integration01Sections01To06.Exercise02;
public static class MainClass
{
    public static decimal CalculateEndingBalance(decimal startingBalance,
        params List<decimal> transactions
        )
    {
        decimal sum = transactions.Sum();
        return sum + startingBalance;
    }
}