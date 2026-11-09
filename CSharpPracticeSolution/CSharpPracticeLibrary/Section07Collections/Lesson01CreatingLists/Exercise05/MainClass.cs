/*
Enter the requirements for this exercise here.
Method signature

public static List<string> CreateProcessingQueue()
Client Requirement

A small accounting department has three types of documents that must be processed each morning.

The processing order is:

Invoices
Payments
Adjustments

Create the morning processing queue and return it to the caller.

Requirements

The returned collection must:

Be a List<string>.
Contain exactly the three document types listed above.
Preserve the required processing order.
Contain no additional items.

Do not print anything to the console.

How you create and populate the List<string> is your decision.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson01CreatingLists.Exercise05;
public static class MainClass
{
    public static List<string> CreateProcessingQueue()
    {
        List<string> processes =
            [
            "Invoices",
            "Payments",
            "Adjustments"
            ];
        return processes;
    }
}