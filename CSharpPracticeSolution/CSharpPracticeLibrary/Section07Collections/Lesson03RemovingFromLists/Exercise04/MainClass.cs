/*
Enter the requirements for this exercise here.
Requirements

A machine stores a list of inspection readings. One reading has been selected for inspection by its index.

Your method must:

Get the reading at inspectionIndex.
If that reading is greater than maximumAllowed:
remove it from the list using RemoveAt();
return true.
Otherwise:
leave the list unchanged;
return false.
Only the reading at inspectionIndex may be considered for removal. Other readings must not affect the decision.
You may assume inspectionIndex is valid.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise04;
public static class MainClass
{
    public static bool RemoveRejectedReading(
    List<int> readings,
    int inspectionIndex,
    int maximumAllowed)
    {
        int item = readings[inspectionIndex];
        if (item > maximumAllowed)
        {
            readings.RemoveAt(inspectionIndex);
            return true;
        }
        return false;
    }
}