namespace CSharpPracticeTests.Integration01Sections01To06.Exercise02;
[Trait("Integration", "Integration01Sections01To0602")]
public class TestClass
{
    [Theory]
    [InlineData(1000, new double[] { 250, -100, 75.50 }, 1225.50)]
    [InlineData(500, new double[] { -125, -50, 200 }, 525)]
    [InlineData(1000, new double[] { }, 1000)]
    [InlineData(0, new double[] { 100, 200, 300 }, 600)]
    [InlineData(500, new double[] { 0, 0, 0 }, 500)]
    [InlineData(100, new double[] { -50, -75 }, -25)]
    public void CalculateEndingBalance_ReturnsExpectedBalance(
        decimal startingBalance,
        double[] transactionValues,
        decimal expected)
    {
        List<decimal> transactions =
            transactionValues
                .Select(x => (decimal)x)
                .ToList();

        decimal actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise02.MainClass
                .CalculateEndingBalance(startingBalance, transactions);

        Assert.Equal(expected, actual);
    }
}