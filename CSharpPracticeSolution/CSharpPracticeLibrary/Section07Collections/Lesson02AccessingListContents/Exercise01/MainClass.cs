/*
Enter the requirements for this exercise here.
Requirement

A warehouse keeps a list of storage zone names in the order they are visited during an inspection.

Create this method:

public static void PrintFirstAndLastZone(List<string> zones)

The method must:

Print the first zone in the list.
Print the last zone in the list.
Print each zone on its own line.
Use list indexing to access the items.
Use the list's Count property to determine the position of the last item.
Example

For this list:

Receiving
Cold Storage
Packing
Shipping

The output should be exactly:

Receiving
Shipping
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson02AccessingListContents.Exercise01;
public static class MainClass
{
    public static void PrintFirstAndLastZone(List<string> zones)
    {
        Console.WriteLine(zones.First());
        Console.WriteLine(zones.Last());
    }
}