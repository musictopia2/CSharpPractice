/*
Create a MainClass with a public static method named CalculateOrder.

Requirements

The method receives:

quantity as an int
pricePerItem as a decimal
discountPercent as an int
an out decimal named subtotal
an out decimal named discountAmount
an out decimal named finalTotal

The method returns a bool.

An order is valid when:

quantity is greater than 0
pricePerItem is greater than or equal to 0
discountPercent is between 0 and 100, inclusive

For a valid order:

subtotal is quantity * pricePerItem.
discountAmount is the specified percentage of the subtotal.
finalTotal is the subtotal minus the discount.
Return true.

For an invalid order:

Set all three out parameters to 0.
Return false.
Examples

For 4 items costing 12.50m each with a 10 percent discount:

subtotal = 50.00m
discountAmount = 5.00m
finalTotal = 45.00m
returns true

For 3 items costing 20.00m each with no discount:

subtotal = 60.00m
discountAmount = 0
finalTotal = 60.00m
returns true

A discount of exactly 100 is valid and results in a final total of 0.
*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson10OutParameters.Exercise04;
public static class MainClass
{
    public static bool CalculateOrder(int quantity, decimal pricePerItem, int discountPercent,
        out decimal subTotal, out decimal discountAmount, out decimal finalTotal
        )
    {
        if (quantity is <= 0 || pricePerItem is < 0)
        {
            subTotal = 0;
            discountAmount = 0;
            finalTotal = 0;
            return false;
        }
        if (discountPercent is < 0 or > 100)
        {
            subTotal = 0;
            discountAmount = 0;
            finalTotal = 0;
            return false;
        }
        subTotal = quantity * pricePerItem;
        discountAmount = subTotal * discountPercent / 100;
        finalTotal = subTotal - discountAmount;
        return true;
    }
}