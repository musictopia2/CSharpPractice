namespace CSharpPracticeLibrary.Section03Operators.Lesson06OrderOfOperations.Exercise03;
public static class MainClass
{
    public static int CalculateAvailableTickets(
    int sections,
    int ticketsPerSection,
    int unavailablePerSection)
    {
        return (ticketsPerSection - unavailablePerSection) * sections;
    }
}