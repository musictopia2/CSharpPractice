namespace CSharpPracticeLibrary.Section03Operators.Lesson05ModuloOperator.Exercise02;
public static class MainClass
{
    public static int GetUnpackedCount(int productCount, int productsPerBox)
    {
        return productCount.Remainder(productsPerBox);
    }
}