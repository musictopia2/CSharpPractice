/*
Create a MainClass with a public static method named GetProductionSummary.

Client Requirement

A manufacturing client records the number of items produced during a shift. Items are packed into batches of a fixed size.

They need a method that reports:

how many complete batches were produced;
how many items remain after creating the complete batches;
whether the production target was reached.
Method Contract

The method receives:

itemsProduced as an int
batchSize as an int
productionTarget as an int
three out parameters:
completeBatches as an int
remainingItems as an int
targetReached as a bool

The method itself returns a bool indicating whether the supplied data was valid.

Validation

The data is valid when:

itemsProduced is 0 or greater.
batchSize is greater than 0.
productionTarget is greater than 0.

If any input is invalid:

Set completeBatches to 0.
Set remainingItems to 0.
Set targetReached to false.
Return false.

For valid data, calculate all three requested results and return true.

Examples

For 87 items, a batch size of 20, and a target of 80:

completeBatches = 4
remainingItems = 7
targetReached = true
method returns true

For 45 items, a batch size of 10, and a target of 50:

completeBatches = 4
remainingItems = 5
targetReached = false
method returns true

*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson10OutParameters.Exercise05;
public static class MainClass
{
    public static bool GetProductionSummary(int itemsProduced, int batchSize,
        int productionTarget,
        out int completeBatches,
        out int remainingItems,
        out bool targetReached
        )
    {
        //if only one variable has or, can use new syntax but not if the or involves several variables.
        if (itemsProduced is < 0 || batchSize is <= 0 || productionTarget is <= 0)
        {
            completeBatches = 0;
            remainingItems = 0;
            targetReached = false;
            return false;
        }
        completeBatches = itemsProduced / batchSize;
        remainingItems = itemsProduced.Remainder(batchSize);
        targetReached = itemsProduced >= productionTarget;
        return true;
    }
}