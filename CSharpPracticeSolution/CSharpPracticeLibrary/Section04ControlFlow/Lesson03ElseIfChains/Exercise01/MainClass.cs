namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson03ElseIfChains.Exercise01;
public static class MainClass
{
    public static string GetShippingPriority(int orderValue)
    {
        if (orderValue >= 500)
        {
            return "Critical";
        }
        if (orderValue >= 300)
        {
            return "High";
        }
        if (orderValue >= 150)
        {
            return "Medium";
        }
        return "Standard";
    }
}