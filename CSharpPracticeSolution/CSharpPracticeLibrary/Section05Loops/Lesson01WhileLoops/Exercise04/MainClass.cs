namespace CSharpPracticeLibrary.Section05Loops.Lesson01WhileLoops.Exercise04;
public static class MainClass
{
    public static int CalculateBoxesNeeded(int currentItems, int itemsPerBox, int requiredItems)
    {
        int needed = currentItems;
        int boxes = 0;
        do
        {
            if (needed >= requiredItems)
            {
                return boxes;
            }
            needed += itemsPerBox;
            boxes++;

        } while (true);
    }
    public static int CalculateBoxesNeeded2(int currentItems, int itemsPerBox, int requiredItems)
    {
        int needed = currentItems;
        int boxes = 0;

        while (needed < requiredItems)
        {
            needed += itemsPerBox;
            boxes++;
        }

        return boxes;
    }
}