namespace CSharpPracticeTests.Section03Operators.Lesson12LogicalNot;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Theory]
    [InlineData(false, false, true)]
    [InlineData(true, false, false)]
    [InlineData(false, true, false)]
    [InlineData(true, true, false)]
    public void IsReady_ReturnsExpectedResult(
        bool isBroken,
        bool isMissing,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson12LogicalNot.Exercise01
                .MainClass.IsReady(isBroken, isMissing);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public void CanStartDownload_ReturnsOppositeOfOfflineStatus(
        bool isOffline,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson12LogicalNot.Exercise02
                .MainClass.CanStartDownload(isOffline);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(50, 40, 60, true)]
    [InlineData(30, 40, 60, false)]
    [InlineData(70, 40, 60, false)]
    [InlineData(40, 40, 60, true)]
    [InlineData(60, 40, 60, true)]
    [InlineData(39, 40, 60, false)]
    [InlineData(61, 40, 60, false)]
    public void IsNormalTemperature_ReturnsExpectedResult(
        int temperature,
        int minimumTemperature,
        int maximumTemperature,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson12LogicalNot.Exercise03
                .MainClass.IsNormalTemperature(
                    temperature,
                    minimumTemperature,
                    maximumTemperature);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(25, 18, false, true)]
    [InlineData(17, 18, false, false)]
    [InlineData(25, 18, true, false)]
    [InlineData(17, 18, true, false)]
    [InlineData(18, 18, false, true)]
    [InlineData(18, 18, true, false)]
    public void CanEnterEvent_ReturnsExpectedResult(
        int age,
        int minimumAge,
        bool isBanned,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson12LogicalNot.Exercise04
                .MainClass.CanEnterEvent(
                    age,
                    minimumAge,
                    isBanned);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(false, false, true, true)]
    [InlineData(true, false, true, false)]
    [InlineData(false, true, true, false)]
    [InlineData(false, false, false, false)]
    [InlineData(true, true, true, false)]
    [InlineData(true, false, false, false)]
    [InlineData(false, true, false, false)]
    [InlineData(true, true, false, false)]
    public void CanProcessOrder_ReturnsExpectedResult(
        bool paymentFailed,
        bool addressMissing,
        bool itemAvailable,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson12LogicalNot.Exercise05
                .MainClass.CanProcessOrder(
                    paymentFailed,
                    addressMissing,
                    itemAvailable);

        Assert.Equal(expected, actual);
    }
}