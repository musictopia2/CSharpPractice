namespace CSharpPracticeTests.Section04ControlFlow.Lesson05SwitchStatements;
[Trait("Section", "Section04ControlFlow")]
public class ExercisesClass
{
    [Theory]
    [InlineData(1, "Received")]
    [InlineData(2, "Processing")]
    [InlineData(3, "Packed")]
    [InlineData(4, "Shipped")]
    [InlineData(5, "Delivered")]
    [InlineData(0, "Unknown status")]
    [InlineData(6, "Unknown status")]
    [InlineData(-1, "Unknown status")]
    [InlineData(100, "Unknown status")]
    public void Exercise01_GetShipmentStatus_ReturnsCorrectStatus(
        int statusCode, string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
            .Lesson05SwitchStatements.Exercise01.MainClass
            .GetShipmentStatus(statusCode);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData('T', "Truck")]
    [InlineData('R', "Rail")]
    [InlineData('S', "Ship")]
    [InlineData('A', "Air")]
    [InlineData('t', "Unknown transport")]
    [InlineData('r', "Unknown transport")]
    [InlineData('X', "Unknown transport")]
    [InlineData('1', "Unknown transport")]
    public void Exercise02_GetTransportName_ReturnsCorrectTransport(
        char transportCode, string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
            .Lesson05SwitchStatements.Exercise02.MainClass
            .GetTransportName(transportCode);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(1, "Cold Storage")]
    [InlineData(2, "Cold Storage")]
    [InlineData(3, "General Storage")]
    [InlineData(4, "General Storage")]
    [InlineData(5, "Secure Storage")]
    [InlineData(0, "Invalid area")]
    [InlineData(6, "Invalid area")]
    [InlineData(-1, "Invalid area")]
    [InlineData(100, "Invalid area")]
    public void Exercise03_GetStorageSection_ReturnsCorrectSection(
        int areaCode, string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
            .Lesson05SwitchStatements.Exercise03.MainClass
            .GetStorageSection(areaCode);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(1, true, "Process Standard")]
    [InlineData(2, true, "Process Priority")]
    [InlineData(3, true, "Process Urgent")]
    [InlineData(1, false, "Waiting for payment")]
    [InlineData(2, false, "Waiting for payment")]
    [InlineData(3, false, "Waiting for payment")]
    [InlineData(0, true, "Invalid priority")]
    [InlineData(0, false, "Invalid priority")]
    [InlineData(4, true, "Invalid priority")]
    [InlineData(4, false, "Invalid priority")]
    [InlineData(-1, false, "Invalid priority")]
    [InlineData(100, true, "Invalid priority")]
    public void Exercise04_GetOrderAction_ReturnsCorrectAction(
        int priorityCode,
        bool paymentReceived,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
            .Lesson05SwitchStatements.Exercise04.MainClass
            .GetOrderAction(priorityCode, paymentReceived);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(1, false, "Package passed")]
    [InlineData(2, false, "Package has minor damage")]
    [InlineData(3, false, "Package has major damage")]
    [InlineData(4, false, "Package rejected")]
    [InlineData(1, true, "Package passed - Review required")]
    [InlineData(2, true, "Package has minor damage - Review required")]
    [InlineData(3, true, "Package has major damage - Review required")]
    [InlineData(4, true, "Package rejected - Review required")]
    [InlineData(0, false, "Invalid inspection code")]
    [InlineData(0, true, "Invalid inspection code")]
    [InlineData(-1, true, "Invalid inspection code")]
    [InlineData(5, false, "Invalid inspection code")]
    [InlineData(100, true, "Invalid inspection code")]
    public void Exercise05_GetInspectionMessage_ReturnsCorrectMessage(
        int inspectionCode,
        bool requiresReview,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
            .Lesson05SwitchStatements.Exercise05.MainClass
            .GetInspectionMessage(inspectionCode, requiresReview);

        Assert.Equal(expected, actual);
    }
}