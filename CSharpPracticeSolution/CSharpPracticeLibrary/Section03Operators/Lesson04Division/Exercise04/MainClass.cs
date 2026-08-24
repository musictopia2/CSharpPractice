namespace CSharpPracticeLibrary.Section03Operators.Lesson04Division.Exercise04;
public static class MainClass
{
    public static double CalculateRemainingShare(
    double startingAmount,
    double amountUsed,
    double numberOfPeople)
    {
        double firsts = startingAmount - amountUsed;
        return firsts / numberOfPeople;
    }
}