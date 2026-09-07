namespace CSharpPracticeLibrary.Section06Methods.Lesson02MethodParameters.Exercise01;
public static class MainClass
{
    public static void Main()
    {
        DisplayProductionTotal(24, 17);
    }
    public static void DisplayProductionTotal(int firstShiftUnits, int secondShiftUnits)
    {
        Console.WriteLine(firstShiftUnits + secondShiftUnits);
    }
}