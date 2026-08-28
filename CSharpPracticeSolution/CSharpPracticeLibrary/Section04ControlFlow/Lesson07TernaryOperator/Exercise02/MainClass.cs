namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson07TernaryOperator.Exercise02;
public static class MainClass
{
    public static string GetStockStatus(int itemCount)
    {
        return itemCount > 0 ? "Available" : "Out of Stock";
    }
}