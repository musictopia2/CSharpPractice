namespace CSharpPracticeLibrary.Section06Methods.Lesson08ParamsArguments.Exercise04;
public static class MainClass
{
    public static int CountAtOrAbove(
    int minimum,
    params List<int> values)
    {
        return values.Count(v => v >= minimum);
    }
}