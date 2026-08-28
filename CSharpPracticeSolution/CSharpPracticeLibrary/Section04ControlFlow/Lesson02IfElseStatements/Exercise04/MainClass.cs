namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson02IfElseStatements.Exercise04;
public static class MainClass
{
    public static void PrintBonusStatus(
    int points,
    int requiredPoints,
    int mistakes,
    int maximumMistakes)
    {
        bool hasBonus = false;
        if (points >= requiredPoints)
        {
            hasBonus = true;
        }
        if (mistakes > maximumMistakes)
        {
            hasBonus = false;
        }
        if (hasBonus)
        {
            Console.WriteLine("Bonus Earned");
        }
        else
        {
            Console.WriteLine("No Bonus");
        }
    }
}