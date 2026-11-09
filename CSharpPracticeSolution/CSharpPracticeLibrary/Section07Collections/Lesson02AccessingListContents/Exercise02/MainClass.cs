/*
Enter the requirements for this exercise here.
Requirement

A company stores four processing stages in a list in this exact order:

Index	Stage
0	Received
1	Reviewed
2	Approved
3	Completed

Create this method:

public static void PrintMiddleStages(List<string> stages)

The method must:

Print the item at index 1.
Print the item at index 2.
Print each item on its own line.
Access both items using their numeric list indexes.
You may assume the list always contains at least four items.*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson02AccessingListContents.Exercise02;
public static class MainClass
{
    public static void PrintMiddleStages(List<string> stages)
    {
        Console.WriteLine(stages[1]);
        Console.WriteLine(stages[2]);
    }
}