/*
Enter the requirements for this exercise here.
The method must:

Receive measurements using an in parameter.
Calculate and return the rectangle's area.
Only read from measurements; do not modify its fields.
If either Width or Height is 0 or less, return 0.

For example:

Width 8, height 5 → 40
Width 0, height 5 → 0
Width 8, height -2 → 0
*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise03;
public static class MainClass
{
    public static double CalculateArea(in RectangleMeasurements measurements)
    {
        if (measurements.Width is <= 0)
        {
            return 0;
        }
        if (measurements.Height is <= 0)
        {
            return 0;
        }
        return measurements.Width * measurements.Height;
    }
}
