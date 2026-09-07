namespace CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise01;
public static class MainClass
{
    public static string CreateShippingLabel(string destination, string shippingType = "Standard")
    {
        return $"Shipping to {destination} - {shippingType}";
    }
}