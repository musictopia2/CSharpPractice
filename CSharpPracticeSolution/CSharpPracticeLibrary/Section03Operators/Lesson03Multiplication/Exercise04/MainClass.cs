namespace CSharpPracticeLibrary.Section03Operators.Lesson03Multiplication.Exercise04;
public static class MainClass
{
    public static int CalculateTotalSeats(int sections, int rowsPerSection, int seatsPerRow)
    {
        int totals = sections * rowsPerSection * seatsPerRow;
        return totals;
    }
}