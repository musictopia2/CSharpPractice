namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson06SwitchExpressions.Exercise04;
public static class MainClass
{
    public static string GetOrderAction(int orderCode)
    {
        return orderCode switch
        {
            < 0 => "Invalid",
            0 => "Pending",
            1 or 2 => "Process",
            >= 3 and <= 5 => "Review",
            _ => "Escalate"
        };
    }
}
/*
Requirements

An order-processing system uses numeric codes to decide what should happen next.

Use a switch expression to return:

orderCode	Return value
Less than 0	"Invalid"
0	"Pending"
1 or 2	"Process"
3 through 5	"Review"
Anything greater than 5	"Escalate"
*/