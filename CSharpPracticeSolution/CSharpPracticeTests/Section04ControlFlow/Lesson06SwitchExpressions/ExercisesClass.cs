namespace CSharpPracticeTests.Section04ControlFlow.Lesson06SwitchExpressions;
[Trait("Section", "Section04ControlFlow")]
public class ExercisesClass
{
    [Theory]
    [InlineData(1, "Standard")]
    [InlineData(2, "Expedited")]
    [InlineData(3, "Priority")]
    [InlineData(4, "Emergency")]
    [InlineData(0, "Unknown")]
    [InlineData(5, "Unknown")]
    [InlineData(-1, "Unknown")]
    [InlineData(100, "Unknown")]
    public void GetDeliveryPriority_ReturnsCorrectDescription(
        int priorityCode,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
                .Lesson06SwitchExpressions.Exercise01.MainClass
                .GetDeliveryPriority(priorityCode);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, "Available")]
    [InlineData(20, "In Use")]
    [InlineData(30, "Maintenance")]
    [InlineData(40, "Retired")]
    [InlineData(0, "Invalid Status")]
    [InlineData(25, "Invalid Status")]
    [InlineData(-10, "Invalid Status")]
    [InlineData(100, "Invalid Status")]
    public void GetEquipmentStatus_ReturnsCorrectStatus(
        int statusCode,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
                .Lesson06SwitchExpressions.Exercise02.MainClass
                .GetEquipmentStatus(statusCode);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(1, "Local")]
    [InlineData(2, "Local")]
    [InlineData(3, "Regional")]
    [InlineData(4, "Regional")]
    [InlineData(5, "National")]
    [InlineData(6, "National")]
    [InlineData(7, "International")]
    [InlineData(0, "Invalid Zone")]
    [InlineData(8, "Invalid Zone")]
    [InlineData(-1, "Invalid Zone")]
    [InlineData(100, "Invalid Zone")]
    public void GetShippingRegion_ReturnsCorrectRegion(
        int zoneNumber,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
                .Lesson06SwitchExpressions.Exercise03.MainClass
                .GetShippingRegion(zoneNumber);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(-10, "Invalid")]
    [InlineData(-1, "Invalid")]
    [InlineData(0, "Pending")]
    [InlineData(1, "Process")]
    [InlineData(2, "Process")]
    [InlineData(3, "Review")]
    [InlineData(4, "Review")]
    [InlineData(5, "Review")]
    [InlineData(6, "Escalate")]
    [InlineData(20, "Escalate")]
    public void GetOrderAction_ReturnsCorrectAction(
        int orderCode,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
                .Lesson06SwitchExpressions.Exercise04.MainClass
                .GetOrderAction(orderCode);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(1, "Account Team")]
    [InlineData(2, "Account Team")]
    [InlineData(3, "Technical Team")]
    [InlineData(4, "Technical Team")]
    [InlineData(5, "Technical Team")]
    [InlineData(6, "Billing Team")]
    [InlineData(7, "Billing Team")]
    [InlineData(8, "Security Team")]
    [InlineData(9, "General Support")]
    [InlineData(25, "General Support")]
    [InlineData(100, "General Support")]
    [InlineData(0, "Invalid Code")]
    [InlineData(-1, "Invalid Code")]
    [InlineData(-50, "Invalid Code")]
    public void GetSupportTeam_ReturnsCorrectTeam(
        int issueCode,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
                .Lesson06SwitchExpressions.Exercise05.MainClass
                .GetSupportTeam(issueCode);

        Assert.Equal(expected, actual);
    }
}