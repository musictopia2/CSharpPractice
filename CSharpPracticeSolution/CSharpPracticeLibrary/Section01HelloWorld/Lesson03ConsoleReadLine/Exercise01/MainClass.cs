namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson03ConsoleReadLine.Exercise01;
public static class MainClass
{
    public static void PrintFavoriteFood()
    {
        string favoriteFood = Console.ReadLine()!;
        Console.WriteLine(favoriteFood);
    }
}