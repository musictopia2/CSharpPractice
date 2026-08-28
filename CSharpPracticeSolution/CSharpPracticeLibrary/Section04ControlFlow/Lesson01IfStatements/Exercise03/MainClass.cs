namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson01IfStatements.Exercise03;
public static class MainClass
{
    public static void CheckPackageWeight(int packageWeight, int maximumWeight)
    {
        if (packageWeight > maximumWeight)
        {
            Console.WriteLine("Package is too heavy");
        }
    }
}