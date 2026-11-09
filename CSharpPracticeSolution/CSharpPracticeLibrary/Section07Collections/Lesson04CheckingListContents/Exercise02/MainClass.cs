/*
Enter the requirements for this exercise here.
Requirements

A delivery driver has a list containing the stop numbers scheduled for the day.

Your method must use both Contains() and IndexOf().

If stopNumber is not in scheduledStops, return exactly:

Stop is not scheduled

If the stop is present, find its first index and return one of these results:

If its index is 0:

Stop is first

If its index is anything other than 0:

Stop is scheduled after X stops

where X is the index.

For example, given:

List<int> scheduledStops =
[
    105,
    210,
    315,
    420
];

Searching for 315 should return:

Stop is scheduled after 2 stops
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise02;
public static class MainClass
{
    public static string CheckDeliveryStop(
    List<int> scheduledStops,
    int stopNumber)
    {
        if (scheduledStops.Contains(stopNumber) == false)
        {
            return "Stop is not scheduled";
        }
        int index = scheduledStops.IndexOf(stopNumber);
        if (index == 0)
        {
            return "Stop is first";
        }
        return $"Stop is scheduled after {index} stops";
    }
}