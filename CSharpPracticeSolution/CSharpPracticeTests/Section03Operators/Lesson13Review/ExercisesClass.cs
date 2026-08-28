namespace CSharpPracticeTests.Section03Operators.Lesson13Review;
[Trait("Section", "Section03Operators")]
public class ExercisesClass
{
    [Theory]
    [InlineData(100, 40, 70, 60, true)]
    [InlineData(50, 20, 30, 50, false)]
    [InlineData(80, 20, 40, 60, true)]
    [InlineData(25, 75, 30, 50, true)]
    [InlineData(100, 0, 51, 50, false)]
    [InlineData(40, 10, 50, 0, true)]
    public void HasEnoughSupply_ReturnsExpectedResult(
        int startingSupply,
        int deliveredSupply,
        int usedSupply,
        int minimumRequired,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson13Review.Exercise01
                .MainClass.HasEnoughSupply(
                    startingSupply,
                    deliveredSupply,
                    usedSupply,
                    minimumRequired);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(25, 6, true)]
    [InlineData(24, 6, false)]
    [InlineData(10, 3, true)]
    [InlineData(100, 10, false)]
    [InlineData(7, 7, false)]
    [InlineData(1, 5, true)]
    public void HasLeftoverItems_ReturnsExpectedResult(
       int itemCount,
       int itemsPerPackage,
       bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson13Review.Exercise02
                .MainClass.HasLeftoverItems(
                    itemCount,
                    itemsPerPackage);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(75, 50, 100, false, true)]
    [InlineData(75, 50, 100, true, false)]
    [InlineData(49, 50, 100, false, false)]
    [InlineData(101, 50, 100, false, false)]
    [InlineData(50, 50, 100, false, true)]
    [InlineData(100, 50, 100, false, true)]
    public void IsScoreAccepted_ReturnsExpectedResult(
        int score,
        int minimumScore,
        int maximumScore,
        bool isDisqualified,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson13Review.Exercise03
                .MainClass.IsScoreAccepted(
                    score,
                    minimumScore,
                    maximumScore,
                    isDisqualified);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(4, 20, 100, true, true)]
    [InlineData(6, 20, 100, false, true)]
    [InlineData(3, 20, 100, false, false)]
    [InlineData(5, 20, 100, false, true)]
    [InlineData(1, 10, 100, true, true)]
    [InlineData(9, 10, 100, false, false)]
    public void QualifiesForDiscount_ReturnsExpectedResult(
        int itemCount,
        int pricePerItem,
        int minimumPurchase,
        bool isMember,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson13Review.Exercise04
                .MainClass.QualifiesForDiscount(
                    itemCount,
                    pricePerItem,
                    minimumPurchase,
                    isMember);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(100, 40, 10, true, true, false, true)]
    [InlineData(100, 45, 10, true, true, false, false)]
    [InlineData(100, 40, 10, false, true, true, true)]
    [InlineData(30, 40, 10, true, true, false, false)]
    [InlineData(100, 40, 10, true, false, false, false)]
    [InlineData(100, 40, 10, false, true, false, false)]
    [InlineData(40, 40, 10, true, true, false, true)]
    [InlineData(100, 40, 10, false, false, true, false)]
    [InlineData(100, 42, 10, false, true, true, false)]
    public void CanApproveDelivery_ReturnsExpectedResult(
        int availableItems,
        int requestedItems,
        int itemsPerBox,
        bool paymentReceived,
        bool addressVerified,
        bool priorityCustomer,
        bool expected)
    {
        bool actual =
            CSharpPracticeLibrary.Section03Operators.Lesson13Review.Exercise05
                .MainClass.CanApproveDelivery(
                    availableItems,
                    requestedItems,
                    itemsPerBox,
                    paymentReceived,
                    addressVerified,
                    priorityCustomer);

        Assert.Equal(expected, actual);
    }
}