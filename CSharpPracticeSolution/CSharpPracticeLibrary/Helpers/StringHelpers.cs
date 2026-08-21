namespace CSharpPracticeLibrary.Helpers;
internal static class StringHelpers
{
    public static string SurroundWithQuotes(string payLoad)
    {
        return $"{ss1.DoubleQuote}{payLoad}{ss1.DoubleQuote}";
    }
    public static string LabelWithQuotes(string label, string content)
    {
        return $"{label}{SurroundWithQuotes(content)}";
    }
    public static string LabelWithTab(string label, string content)
    {
        return $"{label}{ss1.VBTab}{content}";
    }
    public static string LabelWithColon(string label, object content)
    {
        return $"{label}: {content}";
    }
}