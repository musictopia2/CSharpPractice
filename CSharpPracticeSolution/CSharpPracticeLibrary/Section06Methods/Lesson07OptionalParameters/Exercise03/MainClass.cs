namespace CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise03;
public static class MainClass
{
    public static string CreateInventoryNotice(string itemName, int quantity = 1, string location = "Main Warehouse")
    {
        return $"{itemName}: {quantity} available at {location}";
    }
}