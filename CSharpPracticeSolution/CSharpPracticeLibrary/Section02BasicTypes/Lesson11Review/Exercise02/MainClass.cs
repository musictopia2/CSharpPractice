namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise02;
public static class MainClass
{
    public static void PrintProductReceipt(
    string productName,
    int quantity,
    decimal price,
    double rating,
    char category,
    bool inStock,
    float weight)
    {
        Console.WriteLine("=== Product Receipt ===");
        Console.WriteLine(StringHelpers.LabelWithColon("Product", productName));
        Console.WriteLine(StringHelpers.LabelWithColon("Category", category));
        Console.WriteLine(StringHelpers.LabelWithColon("Quantity", quantity));
        Console.WriteLine(StringHelpers.LabelWithColon("Price", $"${price}"));
        Console.WriteLine(StringHelpers.LabelWithColon("Rating", rating));
        Console.WriteLine(StringHelpers.LabelWithColon("Weight", $"{weight} lbs"));
        Console.WriteLine(StringHelpers.LabelWithColon("In Stock", inStock));
        Console.WriteLine("Notes:");
        Console.Write(ss1.VBTab);
        Console.WriteLine(StringHelpers.SurroundWithQuotes("Handle with care"));
        Console.WriteLine(StringHelpers.LabelWithColon("File", @$"C:\Store\Products\{productName}.txt"));
    }
}