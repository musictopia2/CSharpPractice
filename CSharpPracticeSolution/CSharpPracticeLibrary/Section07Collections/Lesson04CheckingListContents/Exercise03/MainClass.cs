/*
Enter the requirements for this exercise here.
Requirements

A production system keeps a list of inspection numbers in the order they are scheduled.

Your method must use both Contains() and IndexOf().

If inspectionNumber does not exist in the list, return exactly:

Inspection not scheduled

If it exists, use its first occurrence to determine the result:

Index 0 or 1:
Inspection scheduled early
Index 2 or 3:
Inspection scheduled middle
Index 4 or greater:
Inspection scheduled late

For example:

List<int> inspectionNumbers =
[
    120,
    240,
    360,
    480,
    600,
    720
];
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise03;
public static class MainClass
{
    public static string CheckInspectionPosition(
    List<int> inspectionNumbers,
    int inspectionNumber)
    {
        if (inspectionNumbers.Contains(inspectionNumber) == false)
        {
            return "Inspection not scheduled";
        }
        int index = inspectionNumbers.IndexOf(inspectionNumber);
        if (index is < 2)
        {
            return "Inspection scheduled early";
        }
        if (index is < 4)
        {
            return "Inspection scheduled middle";
        }
        return "Inspection scheduled late";
    }
}