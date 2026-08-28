namespace CSharpPracticeLibrary.Section03Operators.Lesson13Review.Exercise02;
public static class MainClass
{
    public static bool HasLeftoverItems(
    int itemCount,
    int itemsPerPackage)
    {
        int leftovers = itemCount.Remainder(itemsPerPackage);
        return leftovers > 0;
    }
}