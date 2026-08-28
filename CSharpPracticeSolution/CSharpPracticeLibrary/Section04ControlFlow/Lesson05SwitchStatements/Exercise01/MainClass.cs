namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson05SwitchStatements.Exercise01;
public static class MainClass
{
    public static string GetShipmentStatus(int statusCode)
    {
        switch (statusCode)
        {
            case 1:
                return "Received";
            case 2:
                return "Processing";
            case 3:
                return "Packed";
            case 4:
                return "Shipped";
            case 5:
                return "Delivered";
            default:
                return "Unknown status";

        }
    }
}