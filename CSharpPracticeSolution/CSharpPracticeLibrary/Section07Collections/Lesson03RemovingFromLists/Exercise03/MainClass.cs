/*
Enter the requirements for this exercise here.
equirements

A work queue contains tasks in a specific order. A task has been completed, and its index position is provided.

Your method must:

Get the task located at taskIndex and save its value.
Remove the task at that position using RemoveAt().
Return the value of the task that was removed.
The supplied tasks list must reflect the removal when the method returns.
Example

Given:

["Inspect equipment", "Load truck", "Print report", "Lock warehouse"]

with a taskIndex of 2:

Return "Print report".
The list should become:
["Inspect equipment", "Load truck", "Lock warehouse"]
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise03;
public static class MainClass
{
    public static string RemoveTask(
    List<string> tasks,
    int taskIndex)
    {
        string output = tasks[taskIndex];
        tasks.Remove(output);
        return output;
    }
}