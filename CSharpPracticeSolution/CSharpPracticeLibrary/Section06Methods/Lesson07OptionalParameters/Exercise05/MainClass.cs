namespace CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise05;
public static class MainClass
{
    public static int CalculateDeliveryDays(int standardDays, int delayDays = 0)
    {
        return standardDays + delayDays;
    }
}