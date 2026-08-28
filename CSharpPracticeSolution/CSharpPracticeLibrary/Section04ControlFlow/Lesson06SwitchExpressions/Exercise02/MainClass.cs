namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson06SwitchExpressions.Exercise02;
public static class MainClass
{
    public static string GetEquipmentStatus(int statusCode)
    {
        return statusCode switch
        {
            10 => "Available",
            20 => "In Use",
            30 => "Maintenance",
            40 => "Retired",
            _ => "Invalid Status"
        };
    }
}
/*
Requirements

A warehouse uses numeric codes to represent the current status of a piece of equipment.

Use a switch expression to return:

statusCode	Return value
10	"Available"
20	"In Use"
30	"Maintenance"
40	"Retired"
Anything else	"Invalid Status"
*/