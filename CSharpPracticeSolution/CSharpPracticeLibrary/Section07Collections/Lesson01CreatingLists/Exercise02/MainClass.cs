/*
Enter the requirements for this exercise here.
Method signature

public static void PrintSupplyItems()
Requirements

Create an empty List<string>.

After creating the list, add exactly these three items to it, in this order:

Boxes
Labels
Tape

For this exercise, use the list's Add() method to add each item. This gives you practice with the other basic way of creating/populating a list from the lesson rather than repeating Exercise 01's initialized list.

After the items have been added, print every item in the list to the console, one item per line.

The exact output must be:

Boxes
Labels
Tape
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson01CreatingLists.Exercise02;
public static class MainClass
{
    public static void PrintSupplyItems()
    {
        List<string> items =
            [
            "Boxes",
            "Labels",
            "Tape"
            ];
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}