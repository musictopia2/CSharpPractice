namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise04;
public static class MainClass
{
    public static void PrintAccessCodeInfo(char prefix, int codeNumber)
    {
        Console.WriteLine($"Access Code: {prefix}-{codeNumber}");
        Console.WriteLine($"Prefix: {char.ToUpper(prefix)}");
        Console.WriteLine($"Is Letter: {char.IsLetter(prefix)}");
        Console.WriteLine($"Is Uppercase: {char.IsUpper(prefix)}");
    }
}