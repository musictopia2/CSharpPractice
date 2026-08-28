namespace CSharpPracticeTests.Section03Operators.Lesson11LogicalOr;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Theory]
    [InlineData(4, false, true)]
    [InlineData(1, true, true)]
    [InlineData(1, false, false)]
    [InlineData(3, false, true)]
    [InlineData(3, true, true)]
    public void Exercise01_CanCheckoutEquipment_ReturnsExpectedResult(
    int membershipLevel,
    bool hasStaffApproval,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson11LogicalOr.Exercise01
                .MainClass.CanCheckoutEquipment(
                    membershipLevel,
                    hasStaffApproval);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(75.00, false, true)]
    [InlineData(20.00, true, true)]
    [InlineData(20.00, false, false)]
    [InlineData(50.00, false, true)]
    [InlineData(50.00, true, true)]
    [InlineData(49.99, false, false)]
    public void Exercise02_QualifiesForFreeDelivery_ReturnsExpectedResult(
    decimal orderTotal,
    bool hasFreeDeliveryPass,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson11LogicalOr.Exercise02
                .MainClass.QualifiesForFreeDelivery(
                    orderTotal,
                    hasFreeDeliveryPass);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(true, false, true)]
    [InlineData(false, true, true)]
    [InlineData(true, true, true)]
    [InlineData(false, false, false)]
    public void Exercise03_IsSpecialSchedule_ReturnsExpectedResult(
    bool isWeekend,
    bool isHoliday,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson11LogicalOr.Exercise03
                .MainClass.IsSpecialSchedule(
                    isWeekend,
                    isHoliday);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, 200, true)]
    [InlineData(30, 1500, true)]
    [InlineData(30, 200, false)]
    [InlineData(12, 1000, true)]
    [InlineData(12, 200, true)]
    [InlineData(30, 1000, true)]
    [InlineData(13, 999, false)]
    public void Exercise04_CanEnterForFree_ReturnsExpectedResult(
    int age,
    int loyaltyPoints,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson11LogicalOr.Exercise04
                .MainClass.CanEnterForFree(
                    age,
                    loyaltyPoints);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5, false, true)]
    [InlineData(10, false, true)]
    [InlineData(2, true, true)]
    [InlineData(5, true, true)]
    [InlineData(2, false, false)]
    [InlineData(4, false, false)]
    public void Exercise05_ShouldPrioritizeOrder_ReturnsExpectedResult(
    int daysWaiting,
    bool isPriorityCustomer,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson11LogicalOr.Exercise05
                .MainClass.ShouldPrioritizeOrder(
                    daysWaiting,
                    isPriorityCustomer);

        Assert.Equal(expected, actual);
    }
}