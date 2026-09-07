namespace CSharpPracticeLibrary.Section06Methods.Lesson10OutParameters.Exercise01;
public static class MainClass
{
    public static bool SplitShipment(int numberOfItems, int numberOfContainers, out int itemsPerContainer, out int remainingItems)
    {
        if (numberOfContainers is > 0)
        {
            itemsPerContainer = numberOfItems / numberOfContainers;
            remainingItems = numberOfItems.Remainder(numberOfContainers);
            return true;
        }
        else
        {
            itemsPerContainer = 0;
            remainingItems = 0;
            return false;
        }
    }
}