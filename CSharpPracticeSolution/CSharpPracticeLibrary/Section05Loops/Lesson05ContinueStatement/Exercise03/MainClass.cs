namespace CSharpPracticeLibrary.Section05Loops.Lesson05ContinueStatement.Exercise03;
public static class MainClass
{
    public static void DisplayLabels(List<string> labels)
    {
        foreach (var item in labels)
        {
            if (item == "")
            {
                continue;
            }
            Console.WriteLine(item);
        }
    }
}