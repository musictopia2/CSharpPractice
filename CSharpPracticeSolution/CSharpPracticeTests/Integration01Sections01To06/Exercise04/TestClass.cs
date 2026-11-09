namespace CSharpPracticeTests.Integration01Sections01To06.Exercise04;
[Trait("Integration", "Integration01Sections01To0604")]
public class TestClass
{
    [Theory]
    [InlineData(
        100,
        new double[] { -150, 25, 100, -50 },
        "Ending Balance: $25.00 | Negative Balances: 2")]
    [InlineData(
        50,
        new double[] { -100, 10, 20 },
        "Ending Balance: $-20.00 | Negative Balances: 3")]
    [InlineData(
        500,
        new double[] { 100, -50, 25 },
        "Ending Balance: $575.00 | Negative Balances: 0")]
    [InlineData(
        -100,
        new double[] { },
        "Ending Balance: $-100.00 | Negative Balances: 0")]
    [InlineData(
        -100,
        new double[] { 50, 25 },
        "Ending Balance: $-25.00 | Negative Balances: 2")]
    [InlineData(
        100,
        new double[] { -100, 0, 50 },
        "Ending Balance: $50.00 | Negative Balances: 0")]
    [InlineData(
        0,
        new double[] { -25, 25, -10, 10 },
        "Ending Balance: $0.00 | Negative Balances: 2")]
    public void CreateAccountActivitySummary_ReturnsExpectedSummary(
        decimal startingBalance,
        double[] transactionValues,
        string expected)
    {
        List<decimal> transactions =
            transactionValues
                .Select(x => (decimal)x)
                .ToList();

        string actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise04.MainClass
                .CreateAccountActivitySummary(startingBalance, transactions);

        Assert.Equal(expected, actual);
    }
}