namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson05SwitchStatements.Exercise02;
public static class MainClass
{
    public static string GetTransportName(char transportCode)
    {
        switch (transportCode)
        {
            case 'T':
                return "Truck";
            case 'R':
                return "Rail";
            case 'S':
                return "Ship";
            case 'A':
                return "Air";
            default:
                return "Unknown transport";
        }
    }
}