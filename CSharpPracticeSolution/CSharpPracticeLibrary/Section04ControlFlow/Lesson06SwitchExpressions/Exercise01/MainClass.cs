namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson06SwitchExpressions.Exercise01;
public static class MainClass
{
    public static string GetDeliveryPriority(int priorityCode)
    {
        return priorityCode switch
        {
            1 => "Standard",
            2 => "Expedited",
            3 => "Priority",
            4 => "Emergency",
            _ => "Unknown"
        };
    }
}
/*
Requirements

A shipping system uses numeric codes to describe the priority of a delivery.

Your method must use a switch expression to return the corresponding description:

priorityCode	Return value
1	"Standard"
2	"Expedited"
3	"Priority"
4	"Emergency"
Anything else	"Unknown"
*/