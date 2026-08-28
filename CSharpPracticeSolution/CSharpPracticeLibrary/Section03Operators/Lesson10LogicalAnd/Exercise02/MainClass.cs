namespace CSharpPracticeLibrary.Section03Operators.Lesson10LogicalAnd.Exercise02;
public static class MainClass
{
    public static bool CanAccessAccount(
    bool passwordIsCorrect,
    bool accountIsActive)
    {
        return passwordIsCorrect && accountIsActive;
    }
}