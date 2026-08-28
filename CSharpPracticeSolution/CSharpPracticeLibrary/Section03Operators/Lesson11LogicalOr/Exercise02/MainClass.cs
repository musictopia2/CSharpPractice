namespace CSharpPracticeLibrary.Section03Operators.Lesson11LogicalOr.Exercise02;
public static class MainClass
{
    public static bool QualifiesForFreeDelivery(
    decimal orderTotal,
    bool hasFreeDeliveryPass)
    {
        return orderTotal >= 50 || hasFreeDeliveryPass;
    }
}