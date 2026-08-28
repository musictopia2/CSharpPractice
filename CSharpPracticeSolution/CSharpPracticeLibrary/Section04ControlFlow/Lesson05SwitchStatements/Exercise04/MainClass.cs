namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson05SwitchStatements.Exercise04;
public static class MainClass
{
    public static string GetOrderAction(int priorityCode, bool paymentReceived)
    {
        switch (priorityCode)
        {
            case 1:
                if (paymentReceived)
                {
                    return "Process Standard";
                }
                return "Waiting for payment";
            case 2:
                if (paymentReceived)
                {
                    return "Process Priority";
                }
                return "Waiting for payment";
            case 3:
                if (paymentReceived)
                {
                    return "Process Urgent";
                }
                return "Waiting for payment";
            default:
                return "Invalid priority";
        }
    }
}