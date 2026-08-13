namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson05MultiLineComments.Exercise04;
public static class MainClass
{
    /*
    the method prints a welcome message.
    The write displays the first part does not move to the next line.
    the writeline displays the rest of the text and then returns to the next line.
    The combined statement would make it show "Welcome, Developer!"
*/
    public static void PrintWelcomeMessage()
    {
        Console.Write("Welcome, ");
        Console.WriteLine("Developer!");
    }
}