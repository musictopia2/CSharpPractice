namespace CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise04;
public static class MainClass
{
    public static int CalculateShippingWeight(
    int packageCount,
    int weightPerPackage)
    {
        return packageCount * weightPerPackage;
    }
    public static int CalculateShippingWeight(
    int packageCount,
    int weightPerPackage,
    int containerWeight)
    {
        int firsts = CalculateShippingWeight(packageCount, weightPerPackage);
        return firsts + containerWeight;
    }
}