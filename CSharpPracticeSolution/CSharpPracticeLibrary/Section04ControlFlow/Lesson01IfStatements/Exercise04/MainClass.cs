namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson01IfStatements.Exercise04;
public static class MainClass
{
    public static void CheckInventory(
    int availableItems,
    int minimumItems,
    bool automaticRestocking)
    {
        if (availableItems < minimumItems && automaticRestocking)
        {
            Console.WriteLine("Restock inventory");
        }
    }
}