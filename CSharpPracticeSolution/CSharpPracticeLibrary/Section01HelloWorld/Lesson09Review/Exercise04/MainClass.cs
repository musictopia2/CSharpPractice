namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson09Review.Exercise04;
public static class MainClass
{
    private const string _companyName = "North Star Supplies";
    /*
    This is a method for printing a shipping label.
    Showing a professional way of doing it by showing the companys name.
    And having a person manually enter the name, city and state and sends it there.
*/

    public static void PrintShippingLabel()
    {
        //this is where it asks for the name its being shipped to.
        Console.Write("Enter recipient name: ");
        var name = Console.ReadLine()!;
        Console.Write("Enter city: ");
        string city = Console.ReadLine()!;
        Console.Write("Enter state: ");
        string state = Console.ReadLine()!;
        Console.WriteLine("====================");
        Console.WriteLine(_companyName);
        Console.WriteLine($"SHIP TO: {name}");
        Console.WriteLine($"{city}, {state}");
        Console.WriteLine("====================");
    }
}