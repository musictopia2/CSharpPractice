/*
Enter the requirements for this exercise here.
A shipping system needs to calculate delivery costs in several different ways.

1. Create a public static method named CalculateShippingCost.

   First overload parameters:
   - int packageCount
   - decimal costPerPackage

   Requirements:
   - Return packageCount multiplied by costPerPackage.

2. Create another public static overload named CalculateShippingCost.

   Parameters:
   - int packageCount
   - decimal costPerPackage
   - decimal handlingFee

   Requirements:
   - Calculate the normal shipping cost.
   - Add handlingFee.
   - Return the final decimal result.

3. Create a public static method named TryCalculateShippingCost.

   Parameters:
   - int packageCount
   - decimal costPerPackage
   - decimal handlingFee
   - out decimal shippingCost

   Requirements:
   - If packageCount is negative, costPerPackage is negative,
     or handlingFee is negative:
       - set shippingCost to 0
       - return false

   - Otherwise:
       - Call the three-parameter CalculateShippingCost overload.
       - Put its returned value into shippingCost.
       - Return true.

4. Create a public static method named CreateShippingSummary.

   Parameters:
   - int packageCount
   - decimal shippingCost

   Requirements:
   - Return exactly:

     "{packageCount} packages cost {shippingCost:C}"

   Example:

   CreateShippingSummary(4, 25.50m)

   returns a currency-formatted message such as:

   "4 packages cost $25.50"
*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise04;
public static class MainClass
{
    public static decimal CalculateShippingCost(int packageCount, decimal costPerPackage)
    {
        return packageCount * costPerPackage;
    }
    public static decimal CalculateShippingCost(int packageCount, 
        decimal costPerPackage,
        decimal handlingFee
        )
    {
        decimal firsts = CalculateShippingCost(packageCount, costPerPackage);
        return firsts + handlingFee;
    }
    public static bool TryCalculateShippingCost(int packageCount,
        decimal costPerPackage,
        decimal handlingFee,
        out decimal shippingCost
        )
    {
        if (packageCount < 0 || costPerPackage < 0 || handlingFee < 0)
        {
            shippingCost = 0;
            return false;
        }
        shippingCost = CalculateShippingCost(packageCount, costPerPackage, handlingFee);
        return true;
    }
    public static string CreateShippingSummary(int packageCount,
        decimal shippingCost
        )
    {
        return $"{packageCount} packages cost {shippingCost.ToCurrency()}";
    }
}