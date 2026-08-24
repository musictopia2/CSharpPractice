namespace CSharpPracticeTests.Section03Operators.Lesson07CompoundAssignmentOperators;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Theory]
    [InlineData(20, 10, 5, 4, 2, 50)]
    [InlineData(10, 5, 3, 2, 4, 6)]
    [InlineData(100, 20, 10, 3, 5, 66)]
    [InlineData(5, 0, 1, 10, 2, 20)]
    [InlineData(50, 25, 15, 2, 3, 40)]
    public void Exercise01_UpdateInventory_ReturnsCorrectAmount(
        int startingAmount,
        int deliveryAmount,
        int damagedAmount,
        int packageMultiplier,
        int shipmentDivisor,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson07CompoundAssignmentOperators.Exercise01.MainClass.UpdateInventory(
                startingAmount,
                deliveryAmount,
                damagedAmount,
                packageMultiplier,
                shipmentDivisor);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(100, 50, 30, 2, 240)]
    [InlineData(200, 25, 75, 3, 450)]
    [InlineData(50, 0, 10, 4, 160)]
    [InlineData(25, 25, 50, 5, 0)]
    [InlineData(80, 20, 40, 1, 60)]
    public void Exercise02_CalculateRemainingResources_ReturnsCorrectAmount(
    int resources,
    int gathered,
    int spent,
    int bonusMultiplier,
    int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson07CompoundAssignmentOperators.Exercise02.MainClass.CalculateRemainingResources(
                resources,
                gathered,
                spent,
                bonusMultiplier);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(100, 20, 3, 15, 55)]
    [InlineData(60, 20, 4, 10, 30)]
    [InlineData(50, 0, 5, 8, 18)]
    [InlineData(90, 30, 2, 0, 60)]
    [InlineData(25, 10, 4, 6, 14)]
    public void Exercise03_CalculateProductionTime_ReturnsCorrectAmount(
    int baseTime,
    int extraWork,
    int workerDivisor,
    int cleanupTime,
    int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson07CompoundAssignmentOperators.Exercise03.MainClass.CalculateProductionTime(
                baseTime,
                extraWork,
                workerDivisor,
                cleanupTime);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(80, 25, 9, 4, 24)]
    [InlineData(100, 20, 20, 5, 20)]
    [InlineData(50, 0, 10, 4, 10)]
    [InlineData(30, 10, 0, 8, 5)]
    [InlineData(25, 10, 2, 4, 8)]
    public void Exercise04_CalculateAttendance_ReturnsCorrectAmount(
    int registeredGuests,
    int additionalGuests,
    int cancellations,
    int sessions,
    int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson07CompoundAssignmentOperators.Exercise04.MainClass.CalculateAttendance(
                registeredGuests,
                additionalGuests,
                cancellations,
                sessions);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(120, 30, 10, 7, 20)]
    [InlineData(100, 25, 5, 10, 12)]
    [InlineData(50, 0, 10, 8, 5)]
    [InlineData(40, 20, 0, 6, 10)]
    [InlineData(25, 10, 2, 4, 8)]
    public void Exercise05_CalculateFinalOrder_ReturnsCorrectNumberOfPackages(
    int originalQuantity,
    int addedQuantity,
    int removedQuantity,
    int packageSize,
    int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section03Operators.Lesson07CompoundAssignmentOperators.Exercise05.MainClass.CalculateFinalOrder(
                originalQuantity,
                addedQuantity,
                removedQuantity,
                packageSize);

        Assert.Equal(expected, actual);
    }
}