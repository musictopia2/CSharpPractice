/*
Enter the requirements for this exercise here.
Requirement

A production system stores five inspection readings in a list.

Create this method:

public static int GetSelectedReading(List<int> readings, int index)

The method must:

Accept a list of integer readings.
Accept an index identifying which reading is requested.
Access the list using the provided index.
Return the value stored at that index.
You may assume index is always a valid index for the supplied list.
Examples

Given:

readings:  [18, 24, 31, 27, 40]
index:     2

Return:

31
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson02AccessingListContents.Exercise03;
public static class MainClass
{
    public static int GetSelectedReading(List<int> readings, int index)
    {
        return readings[index];
    }
}