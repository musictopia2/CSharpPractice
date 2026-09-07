namespace CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise02;
public static class MainClass
{
    public static void Main()
    {
        DisplayShippingTotal(32, 9);
    }
    public static void DisplayShippingTotal(int standardPackages, int expressPackages)
    {
        Console.WriteLine(standardPackages + expressPackages);
    }
}