namespace CSharpPracticeTests.Section04ControlFlow.Lesson04LogicalPatterns;
[Trait("Section", "Section04ControlFlow")]
public class ExercisesClass
{
    [Theory]
    [InlineData(2, "Special")]
    [InlineData(3, "Special")]
    [InlineData(4, "Standard")]
    [InlineData(6, "Standard")]
    [InlineData(8, "Standard")]
    [InlineData(0, "Invalid")]
    [InlineData(-1, "Invalid")]
    [InlineData(-20, "Invalid")]
    [InlineData(9, "Bulk")]
    [InlineData(15, "Bulk")]
    [InlineData(20, "Bulk")]
    [InlineData(1, "Oversized")]
    [InlineData(21, "Oversized")]
    [InlineData(100, "Oversized")]
    public void GetHandlingCategory_ReturnsExpectedCategory(
        int handlingCode,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson04LogicalPatterns.Exercise01.MainClass
                .GetHandlingCategory(handlingCode);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(1, "Guest")]
    [InlineData(5, "Guest")]
    [InlineData(10, "Standard")]
    [InlineData(12, "Standard")]
    [InlineData(15, "Standard")]
    [InlineData(0, "Invalid")]
    [InlineData(-1, "Invalid")]
    [InlineData(-10, "Invalid")]
    [InlineData(2, "Restricted")]
    [InlineData(9, "Restricted")]
    [InlineData(16, "Restricted")]
    [InlineData(100, "Restricted")]
    public void Exercise02(int code, string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson04LogicalPatterns.Exercise02.MainClass
                .GetAccessLevel(code);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(1, "Starting")]
    [InlineData(2, "Starting")]
    [InlineData(3, "Starting")]
    [InlineData(10, "Running")]
    [InlineData(14, "Running")]
    [InlineData(15, "Maintenance")]
    [InlineData(16, "Running")]
    [InlineData(20, "Running")]
    [InlineData(0, "Invalid")]
    [InlineData(-1, "Invalid")]
    [InlineData(-20, "Invalid")]
    [InlineData(4, "Unknown")]
    [InlineData(9, "Unknown")]
    [InlineData(21, "Unknown")]
    [InlineData(100, "Unknown")]
    public void Exercise03(int statusCode, string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson04LogicalPatterns.Exercise03.MainClass
                .GetMachineStatus(statusCode);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(-20, "Calibration")]
    [InlineData(-10, "Calibration")]
    [InlineData(-21, "Too Cold")]
    [InlineData(-19, "Too Cold")]
    [InlineData(-11, "Too Cold")]
    [InlineData(-9, "Too Cold")]
    [InlineData(-1, "Too Cold")]
    [InlineData(0, "Too Cold")]
    [InlineData(1, "Cool")]
    [InlineData(10, "Cool")]
    [InlineData(20, "Cool")]
    [InlineData(21, "Normal")]
    [InlineData(25, "Normal")]
    [InlineData(30, "Normal")]
    [InlineData(31, "Too Hot")]
    [InlineData(100, "Too Hot")]
    public void Exercise04(int temperature, string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson04LogicalPatterns.Exercise04.MainClass
                .GetTemperatureAlert(temperature);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(1, "Local")]
    [InlineData(3, "Local")]
    [InlineData(5, "Local")]
    [InlineData(10, "Regional")]
    [InlineData(11, "Regional")]
    [InlineData(14, "Regional")]
    [InlineData(15, "Manual Review")]
    [InlineData(16, "Regional")]
    [InlineData(19, "Regional")]
    [InlineData(20, "Regional")]
    [InlineData(0, "Invalid")]
    [InlineData(-1, "Invalid")]
    [InlineData(-20, "Invalid")]
    [InlineData(2, "Long Distance")]
    [InlineData(9, "Long Distance")]
    [InlineData(21, "Long Distance")]
    [InlineData(100, "Long Distance")]
    public void Exercise05(int zone, string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson04LogicalPatterns.Exercise05.MainClass
                .GetShippingAction(zone);

        Assert.Equal(expected, actual);
    }
}