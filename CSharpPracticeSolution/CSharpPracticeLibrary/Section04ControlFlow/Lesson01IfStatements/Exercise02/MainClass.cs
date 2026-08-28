namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson01IfStatements.Exercise02;
public static class MainClass
{
    public static void CheckFuelLevel(int fuelLevel)
    {
        if (fuelLevel <= 10)
        {
            Console.WriteLine("Low fuel");
        }
    }
}