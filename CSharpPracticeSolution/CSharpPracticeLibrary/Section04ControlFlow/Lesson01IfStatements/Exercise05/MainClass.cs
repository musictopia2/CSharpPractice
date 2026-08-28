namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson01IfStatements.Exercise05;
public static class MainClass
{
    public static void CheckOrderForReview(
    int orderTotal,
    int reviewThreshold,
    bool paymentVerified)
    {
        if (orderTotal >= reviewThreshold || paymentVerified == false)
        {
            Console.WriteLine("Manual review required");
        }
    }
}