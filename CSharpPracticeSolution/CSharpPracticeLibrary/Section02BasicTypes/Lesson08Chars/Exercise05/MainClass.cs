namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise05;
public static class MainClass
{
    public static void PrintCategoryCode(char categoryCode)
    {
        Console.WriteLine($"Category Code: {char.ToUpper(categoryCode)}");
        Console.WriteLine($"Valid Letter: {char.IsLetter(categoryCode)}");
        Console.WriteLine($"Originally Uppercase: {char.IsUpper(categoryCode)}");
    }
}