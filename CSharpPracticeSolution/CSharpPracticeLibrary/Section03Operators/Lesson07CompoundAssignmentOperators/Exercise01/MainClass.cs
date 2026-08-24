namespace CSharpPracticeLibrary.Section03Operators.Lesson07CompoundAssignmentOperators.Exercise01;
public static class MainClass
{
    public static int UpdateInventory(
    int startingAmount,
    int deliveryAmount,
    int damagedAmount,
    int packageMultiplier,
    int shipmentDivisor)
    {
        int output;
        output = startingAmount;
        output += deliveryAmount;
        output -= damagedAmount;
        output *= packageMultiplier;
        output /= shipmentDivisor;
        return output;
    }
}