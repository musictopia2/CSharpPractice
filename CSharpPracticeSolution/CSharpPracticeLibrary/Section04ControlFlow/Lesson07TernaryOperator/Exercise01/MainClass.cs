namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson07TernaryOperator.Exercise01;
public static class MainClass
{
    public static string GetDeliveryPriority(int packageWeight)
    {
        return packageWeight <= 10 ? "Priority" : "Standard";
    }
}