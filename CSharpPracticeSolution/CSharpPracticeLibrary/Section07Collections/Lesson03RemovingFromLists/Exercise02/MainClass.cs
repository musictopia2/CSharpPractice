/*
Enter the requirements for this exercise here.
Requirements

A delivery route contains a list of scheduled stops. The dispatcher may cancel one of those stops.

Your method must:

Attempt to remove stopToCancel from scheduledStops using Remove().
Return true if the stop was found and removed.
Return false if the stop was not in the list.
The supplied scheduledStops list must reflect the removal when the method returns.
If the same stop occurs multiple times, only the first occurrence should be removed.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise02;
public static class MainClass
{
    public static bool CancelStop(
    List<string> scheduledStops,
    string stopToCancel)
    {
        return scheduledStops.Remove(stopToCancel);
    }
}