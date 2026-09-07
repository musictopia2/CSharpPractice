namespace CSharpPracticeLibrary.Section06Methods.Lesson10OutParameters.Exercise02;
public static class MainClass
{
    public static bool CalculateBoxes(int itemCount, int boxCapacity, out int fullBoxes, out int leftOverItems)
    {
        if (boxCapacity <= 0)
        {
            fullBoxes = 0;
            leftOverItems = 0;
            return false;
        }
        fullBoxes = itemCount / boxCapacity;
        leftOverItems = itemCount.Remainder(boxCapacity);
        return true;
    }
}

//could be a good idea to go ahead and keep the requirements here.
/*

Create a MainClass with a public static method named CalculateBoxes.

Requirements

The method receives:

itemCount as an int
boxCapacity as an int
an out int named fullBoxes
an out int named leftoverItems

The method returns a bool.

When boxCapacity is greater than 0:

Set fullBoxes to the number of completely filled boxes.
Set leftoverItems to the number of items that do not fill another complete box.
Return true.

When boxCapacity is 0 or negative:

Set both fullBoxes and leftoverItems to 0.
Return false.
Examples

For 52 items with a box capacity of 10:

fullBoxes = 5
leftoverItems = 2
returns true

For 24 items with a box capacity of 6:

fullBoxes = 4
leftoverItems = 0
returns true

For 30 items with a box capacity of 0:

both out values = 0
returns false

For 30 items with a box capacity of -5:

both out values = 0
returns false
*/