namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson05MultiLineComments.Exercise02;
public static class MainClass
{
    /*
    The method returns the score difference between the starting score and the points lost.
    startingScore is the score a person has to start with
    pointsLost is the points a person lost.
    the value returned is the difference between the starting score and the points lost.
*/
    public static int GetScoreDifference(int startingScore, int pointsLost)
    {
        return startingScore - pointsLost;
    }
}