namespace CSharpPracticeLibrary.Section03Operators.Lesson07CompoundAssignmentOperators.Exercise02;
public static class MainClass
{
    public static int CalculateRemainingResources(
    int resources,
    int gathered,
    int spent,
    int bonusMultiplier)
    {
        int output = resources;
        output += gathered;
        output -= spent;
        output *= bonusMultiplier;
        return output;
    }
}