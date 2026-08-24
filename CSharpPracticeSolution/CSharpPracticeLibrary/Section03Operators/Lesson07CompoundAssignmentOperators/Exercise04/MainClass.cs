namespace CSharpPracticeLibrary.Section03Operators.Lesson07CompoundAssignmentOperators.Exercise04;
public static class MainClass
{
    public static int CalculateAttendance(
    int registeredGuests,
    int additionalGuests,
    int cancellations,
    int sessions)
    {
        int output = registeredGuests;
        output += additionalGuests;
        output -= cancellations;
        output /= sessions;
        return output;
    }
}