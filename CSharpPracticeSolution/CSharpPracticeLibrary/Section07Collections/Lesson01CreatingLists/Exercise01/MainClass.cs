/*
Enter the requirements for this exercise here.
Method signature

public static void PrintDepartments()
Requirements

Create a List<string> containing exactly these three department names, in this order:

Accounting
Shipping
Support

Then print each department to the console on its own line.

The exact output must be:

Accounting
Shipping
Support

For this exercise, actually create and use a List<string>. The purpose is specifically to practice creating a generic list and iterating through its contents.

You may use either foreach or for to print the items.

No return value or parameters are required.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson01CreatingLists.Exercise01;
public static class MainClass
{
    public static void PrintDepartments()
    {
        List<string> departments =
            [
            "Accounting",
            "Shipping",
            "Support"
            ];
        foreach (var item in departments)
        {
            Console.WriteLine(item);
        }
    }
}