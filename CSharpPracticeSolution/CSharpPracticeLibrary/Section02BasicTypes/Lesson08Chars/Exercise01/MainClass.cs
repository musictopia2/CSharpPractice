namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise01;
public static class MainClass
{
    public static void PrintCharacterDetails(char character)
    {
        Console.WriteLine($"Character: {character}");
        Console.WriteLine($"Letter: {char.IsLetter(character)}");
        Console.WriteLine($"Digit: {char.IsDigit(character)}");
        Console.WriteLine($"Lowercase: {char.IsLower(character)}");
    }
}