namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson01IfStatements.Exercise01;
public static class MainClass
{
    public static void CheckHighTemperature(int temperature)
    {
        if (temperature > 90)
        {
            Console.WriteLine("Temperature warning");
        }
    }
}