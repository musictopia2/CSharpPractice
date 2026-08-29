namespace CSharpPracticeTests.Section04ControlFlow.Lesson08Review;
[Trait("Section", "Section04ControlFlow")]
public class ExercisesClass
{
    [Theory]
    [InlineData(0, false, "Invalid Order")]
    [InlineData(0, true, "Invalid Order")]
    [InlineData(-5, false, "Invalid Order")]
    [InlineData(-10, true, "Invalid Order")]
    [InlineData(1, false, "Standard")]
    [InlineData(12, false, "Standard")]
    [InlineData(49, false, "Standard")]
    [InlineData(50, false, "Bulk")]
    [InlineData(75, false, "Bulk")]
    [InlineData(1, true, "Express")]
    [InlineData(49, true, "Express")]
    [InlineData(50, true, "Express")]
    [InlineData(100, true, "Express")]
    public void GetShippingPriority_ReturnsCorrectPriority(
        int itemCount,
        bool isExpress,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson08Review.Exercise01
                .MainClass.GetShippingPriority(itemCount, isExpress);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(-10, false, "Invalid Level")]
    [InlineData(-1, true, "Invalid Level")]
    [InlineData(0, false, "Basic")]
    [InlineData(0, true, "Basic")]
    [InlineData(2, false, "Basic")]
    [InlineData(2, true, "Basic")]
    [InlineData(3, false, "Restricted")]
    [InlineData(3, true, "Secure")]
    [InlineData(5, false, "Restricted")]
    [InlineData(5, true, "Secure")]
    [InlineData(6, false, "Management")]
    [InlineData(6, true, "Management")]
    [InlineData(20, false, "Management")]
    public void GetAccessLevel_ReturnsCorrectAccessLevel(
        int employeeLevel,
        bool hasSecurityClearance,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson08Review.Exercise02
                .MainClass.GetAccessLevel(employeeLevel, hasSecurityClearance);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(0, false, "Invalid Code")]
    [InlineData(0, true, "Invalid Code")]
    [InlineData(-5, false, "Invalid Code")]
    [InlineData(-5, true, "Invalid Code")]
    [InlineData(6, false, "Invalid Code")]
    [InlineData(6, true, "Invalid Code")]
    [InlineData(1, false, "Excellent")]
    [InlineData(2, false, "Good")]
    [InlineData(3, false, "Needs Maintenance")]
    [InlineData(4, false, "Needs Maintenance")]
    [InlineData(5, false, "Replace")]
    [InlineData(1, true, "Remove From Service")]
    [InlineData(3, true, "Remove From Service")]
    [InlineData(5, true, "Remove From Service")]
    public void GetInspectionResult_ReturnsCorrectResult(
        int conditionCode,
        bool hasSafetyIssue,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson08Review.Exercise03
                .MainClass.GetInspectionResult(conditionCode, hasSafetyIssue);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(-5, false, false, "Invalid Shipment")]
    [InlineData(-1, true, true, "Invalid Shipment")]
    [InlineData(0, false, true, "Invalid Shipment")]
    [InlineData(0, true, false, "Invalid Shipment")]
    [InlineData(1, false, false, "Payment Required")]
    [InlineData(20, false, false, "Payment Required")]
    [InlineData(10, true, false, "Payment Required")]
    [InlineData(25, true, false, "Payment Required")]
    [InlineData(1, true, true, "Priority")]
    [InlineData(19, true, true, "Priority")]
    [InlineData(20, true, true, "Priority Bulk")]
    [InlineData(50, true, true, "Priority Bulk")]
    [InlineData(1, false, true, "Standard")]
    [InlineData(19, false, true, "Standard")]
    [InlineData(20, false, true, "Bulk")]
    [InlineData(50, false, true, "Bulk")]
    public void GetDeliveryStatus_ReturnsCorrectStatus(
        int packageCount,
        bool isPriorityCustomer,
        bool paymentReceived,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson08Review.Exercise04
                .MainClass.GetDeliveryStatus(
                    packageCount,
                    isPriorityCustomer,
                    paymentReceived);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(0, false, false, "Invalid Service")]
    [InlineData(0, true, true, "Invalid Service")]
    [InlineData(-1, true, false, "Invalid Service")]
    [InlineData(5, false, true, "Invalid Service")]
    [InlineData(8, true, true, "Invalid Service")]
    [InlineData(1, true, false, "Emergency Dispatch")]
    [InlineData(2, true, true, "Emergency Dispatch")]
    [InlineData(3, true, false, "Emergency Dispatch")]
    [InlineData(4, true, true, "Emergency Dispatch")]
    [InlineData(1, false, true, "Contract Repair")]
    [InlineData(2, false, true, "Contract Repair")]
    [InlineData(1, false, false, "Standard Repair")]
    [InlineData(2, false, false, "Standard Repair")]
    [InlineData(3, false, false, "Inspection")]
    [InlineData(3, false, true, "Inspection")]
    [InlineData(4, false, false, "Replacement")]
    [InlineData(4, false, true, "Replacement")]
    public void GetServiceAction_ReturnsCorrectAction(
        int serviceCode,
        bool isEmergency,
        bool isContractCustomer,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson08Review.Exercise05
                .MainClass.GetServiceAction(
                    serviceCode,
                    isEmergency,
                    isContractCustomer);

        Assert.Equal(expected, actual);
    }
}