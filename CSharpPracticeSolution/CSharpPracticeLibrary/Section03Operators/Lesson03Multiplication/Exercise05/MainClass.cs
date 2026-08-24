namespace CSharpPracticeLibrary.Section03Operators.Lesson03Multiplication.Exercise05;
public static class MainClass
{
    public static int CalculateShipmentWeight(int cartonCount, int unitsPerCarton, int weightPerUnit)
    {
        int totals = cartonCount * unitsPerCarton * weightPerUnit;
        return totals;
    }
}