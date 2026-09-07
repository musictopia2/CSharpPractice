namespace CSharpPracticeLibrary.Section06Methods.Lesson08ParamsArguments.Exercise03;
public static class MainClass
{
    public static int FindLargestReading(
    int defaultReading,
    params List<int> readings)
    {
        if (readings.Count == 0)
        {
            return defaultReading;
        }
        int largest = readings.Max();
        return largest;
    }
}