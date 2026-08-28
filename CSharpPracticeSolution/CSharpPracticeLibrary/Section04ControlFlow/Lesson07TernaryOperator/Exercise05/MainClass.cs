namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson07TernaryOperator.Exercise05;
public static class MainClass
{
    public static int CalculateDeliveryCost(
    int packageCount,
    int costPerPackage,
    bool isPreferredCustomer)
    {
        int deliveryFee = isPreferredCustomer ? 5 : 15;
        int subTotal = packageCount * costPerPackage;
        return subTotal + deliveryFee;
    }
}
/*
The client requires the method to:

Calculate the package cost using packageCount and costPerPackage.
Add a delivery fee of 5 for preferred customers.
Add a delivery fee of 15 for all other customers.
Use the ternary operator (?:) when determining which delivery fee applies.
Return the complete cost, including the delivery fee.
*/