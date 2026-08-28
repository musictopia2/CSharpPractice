namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson03ElseIfChains.Exercise03;
public static class MainClass
{
    public static string GetResponseTime(int priorityLevel)
    {
        if (priorityLevel >= 8)
        {
            return "1 Hour";
        }
        else if (priorityLevel >= 5)
        {
            return "4 Hours";
        }
        else if (priorityLevel >= 3)
        {
            return "12 Hours";
        }
        else
        {
            return "24 Hours";
        }
    }
}