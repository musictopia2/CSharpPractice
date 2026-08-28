namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson05SwitchStatements.Exercise03;
public static class MainClass
{
    public static string GetStorageSection(int areaCode)
    {
        switch (areaCode)
        {
            case 1:
            case 2:
                return "Cold Storage";
            case 3:
            case 4:
                return "General Storage";
            case 5:
                return "Secure Storage";
            default:
                return "Invalid area";
        }
    }
}