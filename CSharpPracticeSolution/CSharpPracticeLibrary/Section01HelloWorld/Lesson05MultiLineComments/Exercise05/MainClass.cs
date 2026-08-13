namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson05MultiLineComments.Exercise05;
public static class MainClass
{
    /*
    This is a method that will print the system status.
    The purpose of this would be to show what the status is at this moment.
    This method displays the system status message. In the current implementation, the status is Ready.
*/

    public static void PrintSystemStatus()
    {
        Console.WriteLine("System Status");
        Console.Write("Current state: ");
        Console.WriteLine("Ready");
    }
}