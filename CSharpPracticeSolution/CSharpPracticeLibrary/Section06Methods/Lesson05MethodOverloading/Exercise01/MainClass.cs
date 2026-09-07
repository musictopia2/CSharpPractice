namespace CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise01;
public static class MainClass
{
    public static int CalculateItems(int firstGroup, int secondGroup)
    {
        return firstGroup + secondGroup;
    }
    public static int CalculateItems(
    int firstGroup,
    int secondGroup,
    int thirdGroup)
    {
        return firstGroup + secondGroup + thirdGroup;
    }
}