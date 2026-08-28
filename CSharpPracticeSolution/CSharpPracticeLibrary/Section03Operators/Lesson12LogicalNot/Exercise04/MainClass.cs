namespace CSharpPracticeLibrary.Section03Operators.Lesson12LogicalNot.Exercise04;
public static class MainClass
{
    public static bool CanEnterEvent(
    int age,
    int minimumAge,
    bool isBanned)
    {
        bool meetsMinimum = age >= minimumAge;
        return meetsMinimum && !isBanned;
    }
}