namespace CSharpPracticeLibrary.Section06Methods.Lesson06NamedArguments.Exercise02;
public static class MainClass
{
    public static string BuildAppointment(
    string customerName,
    int hour,
    bool confirmed)
    {
        return $"Customer: {customerName}, Hour: {hour}, Confirmed: {confirmed}";
    }
    public static string CallAppointment(int scenario)
    {
        if (scenario == 1)
        {
            return BuildAppointment("Jordan", 10, false);
        }
        if (scenario == 2)
        {
            return BuildAppointment(customerName: "Morgan", hour: 2, confirmed: true);
        }
        if (scenario == 3)
        {
            return BuildAppointment("Casey", hour: 4, confirmed: false);
        }
        if (scenario == 4)
        {
            return BuildAppointment("Riley", 7, confirmed: true);
        }

        return "Invalid scenario";
    }
}