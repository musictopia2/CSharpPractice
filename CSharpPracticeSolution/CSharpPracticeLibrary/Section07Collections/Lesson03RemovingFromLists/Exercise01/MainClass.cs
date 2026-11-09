/*
Enter the requirements for this exercise here.
Requirements

A shipping department maintains a list of shipment numbers. One shipment needs to be removed from the list.

Your method must:

Remove shipmentToRemove from shipmentNumbers using the Remove() method.
Return the modified shipmentNumbers list.
If the shipment number does not exist, leave the list unchanged.
If the shipment number occurs more than once, remove only the first occurrence.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise01;
public static class MainClass
{
    public static List<string> RemoveShipment(
    List<string> shipmentNumbers,
    string shipmentToRemove)
    {
        shipmentNumbers.Remove(shipmentToRemove);
        return shipmentNumbers;
    }
}