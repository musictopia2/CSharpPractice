namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson08VarKeyword.Exercise05;
public static class MainClass
{
    public static string CreateShippingEstimate(string productName, int boxCount)
    {
        var totals = boxCount * 5;
        var output = $"Product: {productName}, Boxes: {boxCount}, Estimated weight: {totals} pounds";
        return output;
    }
}