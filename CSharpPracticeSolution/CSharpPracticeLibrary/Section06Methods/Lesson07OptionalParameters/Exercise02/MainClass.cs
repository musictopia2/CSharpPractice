namespace CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise02;
public static class MainClass
{
    public static string CreateReservationMessage(string customerName, int partySize = 2)
    {
        return $"Reservation for {customerName} - Party of {partySize}";
    }
}