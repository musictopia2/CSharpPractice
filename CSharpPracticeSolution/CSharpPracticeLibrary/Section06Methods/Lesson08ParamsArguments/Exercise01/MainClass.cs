namespace CSharpPracticeLibrary.Section06Methods.Lesson08ParamsArguments.Exercise01;
public static class MainClass
{
    public static int CalculateTotalWeight(params List<int> packageWeights)
    {
        return packageWeights.Sum();
    }
}