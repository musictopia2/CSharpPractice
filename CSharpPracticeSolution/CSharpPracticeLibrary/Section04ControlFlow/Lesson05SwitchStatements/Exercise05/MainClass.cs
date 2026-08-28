namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson05SwitchStatements.Exercise05;
public static class MainClass
{
    public static string GetInspectionMessage(int inspectionCode, bool requiresReview)
    {
        string actualAppend = "";
        if (requiresReview)
        {
            actualAppend = " - Review required";
        }
        string firsts;
        switch (inspectionCode)
        {
            case 1:
                firsts = "Package passed";
                break;
            case 2:
                firsts = "Package has minor damage";
                break;
            case 3:
                firsts = "Package has major damage";
                break;
            case 4:
                firsts = "Package rejected";
                break;
            default:
                return "Invalid inspection code";
        }
        return firsts + actualAppend;
    }
}