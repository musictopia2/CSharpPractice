namespace CSharpPracticeTests.Integration01Sections01To06.Exercise05;
[Trait("Integration", "Integration01Sections01To0605")]
public class TestClass
{
    [Theory]
    [InlineData(new double[] { 300, -25, 0, 250, 150 }, 700)]
    [InlineData(new double[] { 100, 200, 300 }, 600)]
    [InlineData(new double[] { -100, -50, 0 }, 0)]
    [InlineData(new double[] { }, 0)]
    [InlineData(new double[] { 125.50, 74.50 }, 200)]
    public void CalculateTotalPayments_ReturnsExpectedTotal(
       double[] paymentValues,
       decimal expected)
    {
        List<decimal> payments =
            paymentValues
                .Select(x => (decimal)x)
                .ToList();

        decimal actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise05.MainClass
                .CalculateTotalPayments(payments);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1000, 700, 300)]
    [InlineData(1000, 1000, 0)]
    [InlineData(1000, 1200, -200)]
    [InlineData(500, 0, 500)]
    public void CalculateRemainingBalance_ReturnsExpectedBalance(
        decimal invoiceAmount,
        decimal totalPayments,
        decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise05.MainClass
                .CalculateRemainingBalance(invoiceAmount, totalPayments);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(
        1000,
        new double[] { 300, -25, 0, 250, 150 },
        "Status: Balance Due | Paid: $700.00 | Remaining: $300.00")]
    [InlineData(
        1000,
        new double[] { 400, 600 },
        "Status: Paid | Paid: $1,000.00 | Remaining: $0.00")]
    [InlineData(
        1000,
        new double[] { 700, 500 },
        "Status: Overpaid | Paid: $1,200.00 | Remaining: $-200.00")]
    [InlineData(
        500,
        new double[] { -100, 0 },
        "Status: Balance Due | Paid: $0.00 | Remaining: $500.00")]
    public void CreatePaymentStatus_ReturnsExpectedStatus(
        decimal invoiceAmount,
        double[] paymentValues,
        string expected)
    {
        List<decimal> payments =
            paymentValues
                .Select(x => (decimal)x)
                .ToList();

        string actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise05.MainClass
                .CreatePaymentStatus(invoiceAmount, payments);

        Assert.Equal(expected, actual);
    }
}