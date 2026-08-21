namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise03;
public static class MainClass
{
    public static void PrintCharacterClassification(char character)
    {
        Console.WriteLine($"Character: {character}");
        Console.WriteLine($"Letter: {char.IsLetter(character)}");
        Console.WriteLine($"Digit: {char.IsDigit(character)}");
        Console.WriteLine($"Letter or digit: {char.IsLetterOrDigit(character)}");
    }
}