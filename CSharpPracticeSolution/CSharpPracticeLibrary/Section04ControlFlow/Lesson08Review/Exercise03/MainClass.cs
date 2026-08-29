namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson08Review.Exercise03;
public static class MainClass
{
    public static string GetInspectionResult(
    int conditionCode,
    bool hasSafetyIssue)
    {
        if (conditionCode is < 1 or > 5)
        {
            return "Invalid Code";
        }
        if (hasSafetyIssue)
        {
            return "Remove From Service";
        }
        if (conditionCode is 1)
        {
            return "Excellent";
        }
        if (conditionCode is 2)
        {
            return "Good";
        }
        if (conditionCode is 3 or 4)
        {
            return "Needs Maintenance";
        }
        if (conditionCode is 5)
        {
            return "Replace";
        }
        return "None";
    }
}
/*
Use these requirements:

If conditionCode is less than 1 or greater than 5, return "Invalid Code".
If hasSafetyIssue is true, return "Remove From Service".
Otherwise:
Code 1 returns "Excellent".
Code 2 returns "Good".
Codes 3 or 4 return "Needs Maintenance".
Code 5 returns "Replace".
*/