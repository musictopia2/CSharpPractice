namespace CSharpPracticeLibrary.Section03Operators.Lesson07CompoundAssignmentOperators.Exercise05;
public static class MainClass
{
    public static int CalculateFinalOrder(
    int originalQuantity,
    int addedQuantity,
    int removedQuantity,
    int packageSize)
    {
        int output = originalQuantity;
        output += addedQuantity;
        output -= removedQuantity;
        output /= packageSize;
        return output;
    }
}