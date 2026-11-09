/*
Enter the requirements for this exercise here.
Requirement

A warehouse stores daily shipment counts in a list.

Create this method:

public static string CompareFirstAndSelectedShipment(
    List<int> shipments,
    int index)

The method must:

Access the first shipment count in the list.
Access the shipment count at the supplied index.
Compare the two values.
Return:
"Selected is higher" if the selected shipment count is greater than the first.
"Selected is lower" if the selected shipment count is less than the first.
"Same amount" if they are equal.
You may assume index is always valid.
Example

Given:

shipments: [40, 55, 30, 65]
index: 3

Return:

Selected is higher

Given:

shipments: [40, 55, 30, 65]
index: 2

Return:

Selected is lower
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson02AccessingListContents.Exercise04;
public static class MainClass
{
    public static string CompareFirstAndSelectedShipment(
    List<int> shipments,
    int index)
    {
        int chosen = shipments[index];
        int first = shipments.First();
        if (chosen > first)
        {
            return "Selected is higher";
        }
        if (chosen < first)
        {
            return "Selected is lower";
        }
        return "Same amount";
    }
}