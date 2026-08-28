namespace CSharpPracticeLibrary.Section03Operators.Lesson10LogicalAnd.Exercise03;
public static class MainClass
{
    public static bool IsTemperatureSafe(int temperature)
    {
        return temperature >= 34 && temperature <= 40;
    }
}