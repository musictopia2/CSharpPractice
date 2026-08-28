namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson06SwitchExpressions.Exercise05;
public static class MainClass
{
    public static string GetSupportTeam(int issueCode)
    {
        return issueCode switch
        {
            1 or 2 => "Account Team",
            3 or 4 or 5 => "Technical Team",
            6 or 7 => "Billing Team",
            8 => "Security Team",
            <=0 => "Invalid Code",
            _ => "General Support"
        };
    }
}
