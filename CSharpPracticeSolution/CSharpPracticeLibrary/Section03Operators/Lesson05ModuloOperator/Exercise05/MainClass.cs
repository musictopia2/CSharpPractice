namespace CSharpPracticeLibrary.Section03Operators.Lesson05ModuloOperator.Exercise05;
public static class MainClass
{
    public static int GetItemsOnPartialPage(int totalItems, int itemsPerPage)
    {
        return totalItems.Remainder(itemsPerPage);
    }
}