namespace CSharpPracticeTests.Integration01Sections01To06.Exercise03;
[Trait("Integration", "Integration01Sections01To0603")]
public class TestClass
{
    [Theory]
    [InlineData(
        new double[] { 250, -40, 0, 500, 75 },
        200,
        "Valid Total: $825.00 | Invalid: 1 | Zero: 1 | Review: 2")]
    [InlineData(
        new double[] { },
        100,
        "Valid Total: $0.00 | Invalid: 0 | Zero: 0 | Review: 0")]
    [InlineData(
        new double[] { 100, 200, 300 },
        200,
        "Valid Total: $600.00 | Invalid: 0 | Zero: 0 | Review: 2")]
    [InlineData(
        new double[] { -10, -20, -30 },
        100,
        "Valid Total: $0.00 | Invalid: 3 | Zero: 0 | Review: 0")]
    [InlineData(
        new double[] { 0, 0, 0 },
        100,
        "Valid Total: $0.00 | Invalid: 0 | Zero: 3 | Review: 0")]
    [InlineData(
        new double[] { 49.99, 50, 75.25, -5, 0 },
        50,
        "Valid Total: $175.24 | Invalid: 1 | Zero: 1 | Review: 2")]

    // Important edge case:
    // zero-value invoices still must NOT count as requiring review.
    [InlineData(
        new double[] { -25, 0, 50, 100 },
        0,
        "Valid Total: $150.00 | Invalid: 1 | Zero: 1 | Review: 2")]

    // Important edge case:
    // negative and zero invoices still must NOT count as requiring review,
    // even when the threshold itself is negative.
    [InlineData(
        new double[] { -100, -10, 0, 5, 20 },
        -50,
        "Valid Total: $25.00 | Invalid: 2 | Zero: 1 | Review: 2")]
    public void CreateInvoiceBatchSummary_ReturnsExpectedSummary(
        double[] invoiceValues,
        decimal reviewThreshold,
        string expected)
    {
        List<decimal> invoiceAmounts =
            invoiceValues
                .Select(x => (decimal)x)
                .ToList();

        string actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise03.MainClass
                .CreateInvoiceBatchSummary(invoiceAmounts, reviewThreshold);

        Assert.Equal(expected, actual);
    }
}