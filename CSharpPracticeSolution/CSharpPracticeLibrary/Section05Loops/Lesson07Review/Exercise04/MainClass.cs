namespace CSharpPracticeLibrary.Section05Loops.Lesson07Review.Exercise04;
public static class MainClass
{
    public static int CountActivePositions(
    int numberOfAisles,
    int positionsPerAisle)
    {
        int count = 0;
        numberOfAisles.Times(n =>
        {
            positionsPerAisle.Times(p =>
            {
                if (p.Remainder(3) > 0)
                {
                    count++;
                }
            });
        });
        return count;
    }
}