namespace CSharpPracticeTests.Section03Operators.Lesson10LogicalAnd;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Theory]
    [InlineData(true, true, true)]
    [InlineData(true, false, false)]
    [InlineData(false, true, false)]
    [InlineData(false, false, false)]
    public void Exercise01_CanCheckoutEquipment(
        bool isAvailable,
        bool hasPermission,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson10LogicalAnd.Exercise01
                .MainClass.CanCheckoutEquipment(
                    isAvailable,
                    hasPermission);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(true, true, true)]
    [InlineData(true, false, false)]
    [InlineData(false, true, false)]
    [InlineData(false, false, false)]
    public void Exercise02_CanAccessAccount(
    bool passwordIsCorrect,
    bool accountIsActive,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson10LogicalAnd.Exercise02
                .MainClass.CanAccessAccount(
                    passwordIsCorrect,
                    accountIsActive);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(34, true)]
    [InlineData(37, true)]
    [InlineData(40, true)]
    [InlineData(33, false)]
    [InlineData(41, false)]
    public void Exercise03_IsTemperatureSafe(
    int temperature,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson10LogicalAnd.Exercise03
                .MainClass.IsTemperatureSafe(temperature);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(10, 5, true, true)]
    [InlineData(5, 5, true, true)]
    [InlineData(4, 5, true, false)]
    [InlineData(10, 5, false, false)]
    [InlineData(4, 5, false, false)]
    public void Exercise04_CanShipOrder(
    int itemsInStock,
    int itemsRequested,
    bool paymentApproved,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson10LogicalAnd.Exercise04
                .MainClass.CanShipOrder(
                    itemsInStock,
                    itemsRequested,
                    paymentApproved);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(19, 20, true, true)]
    [InlineData(19, 20, false, false)]
    [InlineData(20, 20, true, false)]
    [InlineData(20, 20, false, false)]
    [InlineData(0, 20, true, true)]
    public void Exercise05_CanRegisterForWorkshop(
    int currentAttendees,
    int maximumAttendees,
    bool prerequisiteCompleted,
    bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson10LogicalAnd.Exercise05
                .MainClass.CanRegisterForWorkshop(
                    currentAttendees,
                    maximumAttendees,
                    prerequisiteCompleted);

        Assert.Equal(expected, actual);
    }
}