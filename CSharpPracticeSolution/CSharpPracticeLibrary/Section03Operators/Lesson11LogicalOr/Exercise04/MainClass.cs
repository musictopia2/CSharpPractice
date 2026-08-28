namespace CSharpPracticeLibrary.Section03Operators.Lesson11LogicalOr.Exercise04;
public static class MainClass
{
    public static bool CanEnterForFree(
    int age,
    int loyaltyPoints)
    {
        return age <= 12 || loyaltyPoints >= 1000;
    }
}