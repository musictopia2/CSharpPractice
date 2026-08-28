namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson04LogicalPatterns.Exercise04;
public static class MainClass
{
    public static string GetTemperatureAlert(int temperature)
    {
        if (temperature is -20 or -10)
        {
            return "Calibration";
        }
        if (temperature is >=1 and <= 20)
        {
            return "Cool";
        }
        if (temperature is >=21 and <=30)
        {
            return "Normal";
        }    
        if (temperature is not > 0)
        {
            return "Too Cold";
        }
        if (temperature is > 30)
        {
            return "Too Hot";
        }
        return "Unknown";
    }
}