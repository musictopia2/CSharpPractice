namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson03ElseIfChains.Exercise05;
public static class MainClass
{
    public static string GetServiceRoute(
    bool systemOffline,
    bool customerLockedOut,
    bool paymentIssue,
    bool generalQuestion)
    {
        if (systemOffline)
        {
            return "Emergency Support";
        }
        else if (customerLockedOut)
        {
            return "Account Support";
        }
        else if (paymentIssue)
        {
            return "Billing Support";
        }
        else if (generalQuestion)
        {
            return "General Support";
        }
        else
        {
            return "No Action Required";
        }
    }
}