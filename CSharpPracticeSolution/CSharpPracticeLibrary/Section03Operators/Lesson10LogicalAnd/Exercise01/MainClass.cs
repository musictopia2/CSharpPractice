namespace CSharpPracticeLibrary.Section03Operators.Lesson10LogicalAnd.Exercise01;
public static class MainClass
{
    public static bool CanCheckoutEquipment(
    bool isAvailable,
    bool hasPermission)
    {
        return isAvailable && hasPermission;
    }
}