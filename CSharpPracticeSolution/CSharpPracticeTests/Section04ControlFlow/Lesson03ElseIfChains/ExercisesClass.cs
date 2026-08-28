namespace CSharpPracticeTests.Section04ControlFlow.Lesson03ElseIfChains;
[Trait("Section", "Section04ControlFlow")]
public class ExercisesClass
{
    [Theory]
    [InlineData(650, "Critical")]
    [InlineData(500, "Critical")]
    [InlineData(499, "High")]
    [InlineData(375, "High")]
    [InlineData(300, "High")]
    [InlineData(299, "Medium")]
    [InlineData(200, "Medium")]
    [InlineData(150, "Medium")]
    [InlineData(149, "Standard")]
    [InlineData(80, "Standard")]
    public void GetShippingPriority_ReturnsCorrectPriority(
        int orderValue,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
                .Lesson03ElseIfChains.Exercise01.MainClass
                .GetShippingPriority(orderValue);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(75, "Heavy Package")]
    [InlineData(50, "Heavy Package")]
    [InlineData(49, "Medium Package")]
    [InlineData(30, "Medium Package")]
    [InlineData(25, "Medium Package")]
    [InlineData(24, "Light Package")]
    [InlineData(15, "Light Package")]
    [InlineData(10, "Light Package")]
    [InlineData(9, "Small Package")]
    [InlineData(0, "Small Package")]
    public void GetPackageDescription_ReturnsCorrectDescription(
        int weight,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
                .Lesson03ElseIfChains.Exercise02.MainClass
                .GetPackageDescription(weight);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, "1 Hour")]
    [InlineData(8, "1 Hour")]
    [InlineData(7, "4 Hours")]
    [InlineData(6, "4 Hours")]
    [InlineData(5, "4 Hours")]
    [InlineData(4, "12 Hours")]
    [InlineData(3, "12 Hours")]
    [InlineData(2, "24 Hours")]
    [InlineData(1, "24 Hours")]
    [InlineData(0, "24 Hours")]
    public void GetResponseTime_ReturnsCorrectResponseTime(
        int priorityLevel,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
                .Lesson03ElseIfChains.Exercise03.MainClass
                .GetResponseTime(priorityLevel);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(20, 10, true, true, "Ready for Delivery")]
    [InlineData(10, 10, true, true, "Ready for Delivery")]
    [InlineData(5, 10, true, true, "Insufficient Stock")]
    [InlineData(20, 10, false, true, "Payment Required")]
    [InlineData(20, 10, true, false, "Address Verification Required")]

    // Multiple problems: first applicable rule must win.
    [InlineData(5, 10, false, true, "Insufficient Stock")]
    [InlineData(5, 10, false, false, "Insufficient Stock")]
    [InlineData(20, 10, false, false, "Payment Required")]
    public void GetDeliveryStatus_ReturnsCorrectStatus(
        int availableItems,
        int requestedItems,
        bool paymentReceived,
        bool addressVerified,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
                .Lesson03ElseIfChains.Exercise04.MainClass
                .GetDeliveryStatus(
                    availableItems,
                    requestedItems,
                    paymentReceived,
                    addressVerified);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(true, false, false, false, "Emergency Support")]
    [InlineData(false, true, false, false, "Account Support")]
    [InlineData(false, false, true, false, "Billing Support")]
    [InlineData(false, false, false, true, "General Support")]
    [InlineData(false, false, false, false, "No Action Required")]

    // Multiple conditions are true.
    // The highest-priority applicable route must win.
    [InlineData(true, true, true, true, "Emergency Support")]
    [InlineData(false, true, true, true, "Account Support")]
    [InlineData(false, false, true, true, "Billing Support")]
    [InlineData(true, false, false, true, "Emergency Support")]
    public void GetServiceRoute_ReturnsCorrectRoute(
       bool systemOffline,
       bool customerLockedOut,
       bool paymentIssue,
       bool generalQuestion,
       string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow
                .Lesson03ElseIfChains.Exercise05.MainClass
                .GetServiceRoute(
                    systemOffline,
                    customerLockedOut,
                    paymentIssue,
                    generalQuestion);

        Assert.Equal(expected, actual);
    }
}