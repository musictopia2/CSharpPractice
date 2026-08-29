namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson08Review.Exercise02;
public static class MainClass
{
    public static string GetAccessLevel(
    int employeeLevel,
    bool hasSecurityClearance)
    {
        if (employeeLevel is < 0)
        {
            return "Invalid Level";
        }
        if (employeeLevel is 0 or 1 or 2)
        {
            return "Basic";
        }
        if (employeeLevel is 3 or 4 or 5)
        {
            if (hasSecurityClearance)
            {
                return "Secure";
            }
            return "Restricted";
        }
        if (employeeLevel is >= 6)
        {
            return "Management";
        }
        return "None";
    }
}