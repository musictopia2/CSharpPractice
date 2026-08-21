namespace CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise01;
public static class MainClass
{
    public static bool CanUseEquipment(bool completedSafetyTraining, bool hasPermission)
    {
        if (completedSafetyTraining && hasPermission)
        {
            return true;
        }
        return false;
    }
}