namespace CSharpPracticeLibrary.Section03Operators.Lesson12LogicalNot.Exercise03;
public static class MainClass
{
    public static bool IsNormalTemperature(
    int temperature,
    int minimumTemperature,
    int maximumTemperature)
    {
        //has to do a different way otherwise one liners which i don't know how to do.

        bool isTooCold = temperature < minimumTemperature;
        bool isTooHot = temperature > maximumTemperature;
        return !isTooCold && !isTooHot;

        //if (temperature < minimumTemperature)
        //{
        //    return false;
        //}
        //if (temperature > maximumTemperature)
        //{
        //    return false;
        //}
        //return true;

    }
}