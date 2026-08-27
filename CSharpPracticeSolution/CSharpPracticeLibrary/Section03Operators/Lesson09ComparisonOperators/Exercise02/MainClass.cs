namespace CSharpPracticeLibrary.Section03Operators.Lesson09ComparisonOperators.Exercise02;
public static class MainClass
{
    public static bool IsFreezing(int temperature)
    {
        return temperature <= 32;
    }

    public static bool IsAboveFreezing(int temperature)
    {
        return temperature > 32;
    }

    public static bool IsWithinMaximum(int temperature, int maximumTemperature)
    {
        return temperature <= maximumTemperature;
    }

    public static bool HasTemperatureChanged(int previousTemperature, int currentTemperature)
    {
        return previousTemperature != currentTemperature;
    }

}