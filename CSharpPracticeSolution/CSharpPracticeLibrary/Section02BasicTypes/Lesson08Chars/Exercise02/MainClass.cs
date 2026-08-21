namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise02;
public static class MainClass
{
    public static void PrintCaseConversion(char character)
    {
        Console.WriteLine($"Original: {character}");
        Console.WriteLine($"Uppercase: {char.ToUpper(character)}");
        Console.WriteLine($"Lowercase: {char.ToLower(character)}");
    }
}