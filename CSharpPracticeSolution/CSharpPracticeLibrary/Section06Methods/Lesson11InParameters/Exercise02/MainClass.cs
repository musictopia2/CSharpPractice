/*
Enter the requirements for this exercise here.
Requirements

The method must:

Receive stock using an in parameter.
Calculate the total weight by multiplying the number of Units by WeightPerUnit.
Return the total as a double.
Only read the fields of stock; do not modify them.

For example, if there are 6 units and each weighs 2.5, the total weight is 15.0.
*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise02;
public static class MainClass
{
    public static double CalculateTotalWeight(in InventoryStock stock)
    {
        return stock.WeightPerUnit * stock.Units;
    }
}