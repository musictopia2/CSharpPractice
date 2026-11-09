/*
Enter the requirements for this exercise here.
Requirement

Create a public static method named:

CalculateInvoiceTotal

It receives:

decimal subtotal
decimal discountPercent

It returns the final invoice total as a decimal.

Apply these rules:

If subtotal is less than 0, return 0.
If discountPercent is less than 0, treat the discount as 0%.
If discountPercent is greater than 100, treat the discount as 100%.
Otherwise, use the supplied discount percentage.
Calculate the discount amount from the subtotal.
Subtract the discount amount from the subtotal.
Return the resulting invoice total.
Examples

A subtotal of 800.00m with a 10m percent discount returns:

720.00

A subtotal of 500.00m with a negative discount percentage uses 0%, returning:

500.00

A subtotal of 500.00m with a 120m percent discount uses 100%, returning:

0.00

This one deliberately doesn't require loops. Exercises 1–2 only need to integrate 3–4 sections; we'll start requiring essentially everything in Exercises 3–4.
*/

namespace CSharpPracticeLibrary.Integration01Sections01To06.Exercise01;
public static class MainClass
{
    public static decimal CalculateInvoiceTotal(decimal subTotal, decimal discountPercent)
    {
        if (subTotal < 0)
        {
            return 0;
        }
        if (discountPercent > 100)
        {
            discountPercent = 100;
        }
        if (discountPercent < 0)
        {
            discountPercent = 0;
        }
        decimal savings = subTotal * discountPercent / 100;
        return subTotal - savings;
    }
}