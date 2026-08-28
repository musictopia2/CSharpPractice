namespace CSharpPracticeLibrary.Section03Operators.Lesson11LogicalOr.Exercise03;
public static class MainClass
{
    public static bool IsSpecialSchedule(
    bool isWeekend,
    bool isHoliday)
    {
        return isWeekend || isHoliday;
    }
}