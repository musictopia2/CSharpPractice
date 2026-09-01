namespace CSharpPracticeLibrary.Section05Loops.Lesson07Review.Exercise05;
public static class MainClass
{
    public static int CountPackagesForDelivery(
    List<int> packagesPerBatch)
    {
        int count = 0;
        foreach (var item in packagesPerBatch)
        {
            if (item == 0)
            {
                continue;
            }
            item.Times(x =>
            {
                if (x.Remainder(5) > 0)
                {
                    count++;
                }
            });
        }
        return count;
    }
}