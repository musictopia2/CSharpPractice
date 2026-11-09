namespace CSharpPracticeTests.Integration01Sections01To06.Exercise09;
[Trait("Integration", "Integration01Sections01To0609")]
public class TestClass
{
    [Theory]
    [InlineData(
        new double[] { 500, 1200, 0, -100, 750 },
        new double[] { 1000, 1000, 500, 500, 500 },
        "Balances Owed: $2,450.00 | Customers Owing: 3 | Over Limit: 2 | Amount Over Limit: $450.00")]
    [InlineData(
        new double[] { 100, 200, 300 },
        new double[] { 500, 500, 500 },
        "Balances Owed: $600.00 | Customers Owing: 3 | Over Limit: 0 | Amount Over Limit: $0.00")]
    [InlineData(
        new double[] { 600, 800, 1000 },
        new double[] { 500, 500, 500 },
        "Balances Owed: $2,400.00 | Customers Owing: 3 | Over Limit: 3 | Amount Over Limit: $900.00")]
    [InlineData(
        new double[] { 500, 750, 1000 },
        new double[] { 500, 750, 1000 },
        "Balances Owed: $2,250.00 | Customers Owing: 3 | Over Limit: 0 | Amount Over Limit: $0.00")]
    [InlineData(
        new double[] { 0, -100, -250 },
        new double[] { 0, 50, 100 },
        "Balances Owed: $0.00 | Customers Owing: 0 | Over Limit: 0 | Amount Over Limit: $0.00")]
    [InlineData(
        new double[] { 1250.50, 450.25, -10, 0 },
        new double[] { 1000, 500, 100, 100 },
        "Balances Owed: $1,700.75 | Customers Owing: 2 | Over Limit: 1 | Amount Over Limit: $250.50")]
    [InlineData(
        new double[] { },
        new double[] { },
        "Balances Owed: $0.00 | Customers Owing: 0 | Over Limit: 0 | Amount Over Limit: $0.00")]
    public void CreateCustomerAccountReport_ReturnsExpectedReport(
        double[] balanceValues,
        double[] creditLimitValues,
        string expected)
    {
        List<decimal> accountBalances =
            balanceValues
                .Select(x => (decimal)x)
                .ToList();

        List<decimal> creditLimits =
            creditLimitValues
                .Select(x => (decimal)x)
                .ToList();

        string actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise09.MainClass
                .CreateCustomerAccountReport(
                    accountBalances,
                    creditLimits);

        Assert.Equal(expected, actual);
    }
}