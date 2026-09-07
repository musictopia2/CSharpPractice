namespace CSharpPracticeLibrary.Section06Methods.Lesson09RefParameters.Exercise04;
public static class MainClass
{
    public static void PutSmallerFirst(ref int firstMeasurement, ref int secondMeasurement)
    {
        int tempFirst = firstMeasurement;
        int tempSecond = secondMeasurement;
        if (tempFirst > secondMeasurement)
        {
            firstMeasurement = tempSecond;
            secondMeasurement = tempFirst;
        }
    }
}