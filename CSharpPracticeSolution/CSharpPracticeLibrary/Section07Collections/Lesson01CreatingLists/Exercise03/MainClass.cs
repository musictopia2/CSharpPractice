/*
Enter the requirements for this exercise here.
public static List<int> CreatePriorityLevels()
Requirements

Create a List<int> containing exactly these priority levels, in this order:

10
20
30
40

Return the completed list.

For this exercise:

The returned object must be a List<int>.
It must contain exactly four items.
The items must remain in the specified order.
Do not print anything to the console.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson01CreatingLists.Exercise03;
public static class MainClass
{
    public static List<int> CreatePriorityLevels()
    {
        List<int> levels =
            [
            10, 20, 30, 40
            ];
        return levels;
    }
}