/*
Requirements

The method receives:

totalSeconds as an int
an out int named minutes
an out int named seconds

The method returns a bool.

When totalSeconds is 0 or greater:

Set minutes to the number of complete minutes.
Set seconds to the remaining seconds.
Return true.

When totalSeconds is negative:

Set both minutes and seconds to 0.
Return false.
Examples

For 145 total seconds:

minutes = 2
seconds = 25
returns true

For 300 total seconds:

minutes = 5
seconds = 0
returns true

For 42 total seconds:

minutes = 0
seconds = 42
returns true

For 0 total seconds:

minutes = 0
seconds = 0
returns true

For -30 total seconds:

both out values = 0
returns false
*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson10OutParameters.Exercise03;
public static class MainClass
{
    public static bool CalculateTime(int totalSeconds, out int minutes, out int seconds)
    {
        if (totalSeconds < 0)
        {
            minutes = 0;
            seconds = 0;
            return false;
        }
        seconds = totalSeconds.Remainder(60);
        minutes = totalSeconds / 60;
        return true;
    }
}