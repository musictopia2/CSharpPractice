namespace CSharpPracticeLibrary.Section06Methods.Lesson08ParamsArguments.Exercise05;
public static class MainClass
{
    public static string CreateInventoryAlert(
    string productName,
    int minimumStock,
    params List<int> warehouseStock)
    {
        int total = warehouseStock.Sum();
        if (total < minimumStock)
        {
            return $"{productName}: {total} units - Low Stock";

        }
        else
        {
            return $"{productName}: {total} units - Sufficient";
        }
    }
}