namespace CSharpPracticeLibrary.Section05Loops.Lesson06NestedLoops.Exercise03;
public static class MainClass
{
    public static int CountDeliveryChecks(
    List<int> routes,
    List<int> stops)
    {
        int count = 0;
        foreach (int route in routes)
        {
            foreach (int stop in stops)
            {
                count++;
            }
        }
        return count;
    }
}
/*
Requirements

A delivery company has several routes, and every route contains the same set of numbered stops.

Use nested foreach loops:

The outer loop processes each route.
The inner loop processes every stop for that route.
Each time the inner loop processes a stop, count one delivery check.
Return the total number of delivery checks after all routes have been processed.
*/