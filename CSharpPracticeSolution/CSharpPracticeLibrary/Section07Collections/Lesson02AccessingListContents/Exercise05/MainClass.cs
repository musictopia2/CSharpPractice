/*
Enter the requirements for this exercise here.
A shipping company receives a list containing package weights in the order the packages were loaded onto a truck.

The client needs a method that checks three specific positions so an employee can quickly verify part of the loading sequence.

Create:

public static string CreateLoadingCheck(
    List<int> packageWeights,
    int inspectionIndex)
Client requirements

Retrieve these three values from the list:

The package at index 0.
The package at index 1.
The package at inspectionIndex.

Then determine the result:

If the package at inspectionIndex is greater than both packages at indexes 0 and 1, return "Inspection package is heaviest".
If it is less than both, return "Inspection package is lightest".
Otherwise, return "Inspection package is between".

You may assume:

The list contains at least three packages.
inspectionIndex is valid.
Examples

For:

packageWeights = [20, 30, 45, 25]
inspectionIndex = 2

45 is greater than both 20 and 30, so return:

Inspection package is heaviest

For:

packageWeights = [20, 30, 10, 40]
inspectionIndex = 2

return:

Inspection package is lightest

For:

packageWeights = [20, 30, 25, 40]
inspectionIndex = 2

return:

Inspection package is between
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson02AccessingListContents.Exercise05;
public static class MainClass
{
    public static string CreateLoadingCheck(
    List<int> packageWeights,
    int inspectionIndex)
    {
        int itemChecked = packageWeights[inspectionIndex];
        int firstItem = packageWeights.First();
        int secondItem = packageWeights[1];
        if (itemChecked > firstItem && itemChecked > secondItem)
        {
            return "Inspection package is heaviest";
        }
        if (itemChecked < firstItem && itemChecked < secondItem)
        {
            return "Inspection package is lightest";
        }
        return "Inspection package is between";
    }
}