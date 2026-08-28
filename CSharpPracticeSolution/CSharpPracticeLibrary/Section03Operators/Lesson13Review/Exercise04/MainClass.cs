namespace CSharpPracticeLibrary.Section03Operators.Lesson13Review.Exercise04;
public static class MainClass
{
    public static bool QualifiesForDiscount(
    int itemCount,
    int pricePerItem,
    int minimumPurchase,
    bool isMember)
    {
        int totalPurchase = itemCount * pricePerItem;
        bool proper = totalPurchase >= minimumPurchase;
        return proper || isMember;
    }
}