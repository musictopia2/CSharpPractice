namespace CSharpPracticeTests.Section04ControlFlow.Lesson07TernaryOperator;
[Trait("Section", "Section04ControlFlow")]
public class ExercisesClass
{
    [Theory]
    [InlineData(1, "Priority")]
    [InlineData(6, "Priority")]
    [InlineData(9, "Priority")]
    [InlineData(10, "Priority")]
    [InlineData(11, "Standard")]
    [InlineData(18, "Standard")]
    [InlineData(50, "Standard")]
    public void Exercise01_GetDeliveryPriority_ReturnsExpectedResult(
        int packageWeight,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson07TernaryOperator.Exercise01
                .MainClass.GetDeliveryPriority(packageWeight);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(25, "Available")]
    [InlineData(10, "Available")]
    [InlineData(1, "Available")]
    [InlineData(0, "Out of Stock")]
    [InlineData(-1, "Out of Stock")]
    [InlineData(-20, "Out of Stock")]
    public void Exercise02_GetStockStatus_ReturnsExpectedResult(
        int itemCount,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson07TernaryOperator.Exercise02
                .MainClass.GetStockStatus(itemCount);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(80, 75, 100)]
    [InlineData(75, 75, 100)]
    [InlineData(74, 75, 0)]
    [InlineData(100, 100, 100)]
    [InlineData(99, 100, 0)]
    [InlineData(20, 50, 0)]
    public void Exercise03_GetBonusPoints_ReturnsExpectedResult(
        int score,
        int requiredScore,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson07TernaryOperator.Exercise03
                .MainClass.GetBonusPoints(score, requiredScore);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5, 20, true, 90)]
    [InlineData(5, 20, false, 100)]
    [InlineData(3, 15, true, 35)]
    [InlineData(3, 15, false, 45)]
    [InlineData(10, 12, true, 110)]
    [InlineData(10, 12, false, 120)]
    public void Exercise04_CalculateFinalCost_ReturnsExpectedResult(
        int itemCount,
        int pricePerItem,
        bool isMember,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson07TernaryOperator.Exercise04
                .MainClass.CalculateFinalCost(itemCount, pricePerItem, isMember);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(4, 20, true, 85)]
    [InlineData(4, 20, false, 95)]
    [InlineData(2, 30, true, 65)]
    [InlineData(2, 30, false, 75)]
    [InlineData(10, 5, true, 55)]
    [InlineData(10, 5, false, 65)]
    public void Exercise05_CalculateDeliveryCost_ReturnsExpectedResult(
       int packageCount,
       int costPerPackage,
       bool isPreferredCustomer,
       int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section04ControlFlow.Lesson07TernaryOperator.Exercise05
                .MainClass.CalculateDeliveryCost(
                    packageCount,
                    costPerPackage,
                    isPreferredCustomer);

        Assert.Equal(expected, actual);
    }
}