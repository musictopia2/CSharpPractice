namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson06SwitchExpressions.Exercise03;
public static class MainClass
{
    public static string GetShippingRegion(int zoneNumber)
    {
        return zoneNumber switch
        {
            1 or 2 => "Local",
            3 or 4 => "Regional",
            5 or 6 => "National",
            7 => "International",
            _ => "Invalid Zone"
        };
    }
}