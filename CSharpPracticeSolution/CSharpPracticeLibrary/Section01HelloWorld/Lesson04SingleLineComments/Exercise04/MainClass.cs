namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson04SingleLineComments.Exercise04;
public static class MainClass
{
    public static void PrintPlayerName()
    {
        //this is showing the program is reading the player's name.
        string name = Console.ReadLine()!;
        Console.WriteLine(name);
        //Console.WriteLine("Testing player input");
    }
}