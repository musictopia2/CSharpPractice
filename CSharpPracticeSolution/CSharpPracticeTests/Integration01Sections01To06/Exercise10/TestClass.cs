namespace CSharpPracticeTests.Integration01Sections01To06.Exercise10;
[Trait("Integration", "Integration01Sections01To0610")]
public class TestClass
{
    [Theory]
    [InlineData(
        new double[] { 500, 425, 340, -25, 0 },
        new double[] { 500, 500, 300, 100, 0 },
        "Actual: $1,265.00 | Expected: $1,300.00 | Matched: 2 | Short: 1 | Overpaid: 1 | Shortage: $75.00 | Overpayment: $40.00")]
    [InlineData(
        new double[] { 100, 200, 300 },
        new double[] { 100, 200, 300 },
        "Actual: $600.00 | Expected: $600.00 | Matched: 3 | Short: 0 | Overpaid: 0 | Shortage: $0.00 | Overpayment: $0.00")]
    [InlineData(
        new double[] { 80, 150, 250 },
        new double[] { 100, 200, 300 },
        "Actual: $480.00 | Expected: $600.00 | Matched: 0 | Short: 3 | Overpaid: 0 | Shortage: $120.00 | Overpayment: $0.00")]
    [InlineData(
        new double[] { 125, 250, 400 },
        new double[] { 100, 200, 300 },
        "Actual: $775.00 | Expected: $600.00 | Matched: 0 | Short: 0 | Overpaid: 3 | Shortage: $0.00 | Overpayment: $175.00")]
    [InlineData(
        new double[] { -100, -50, -25 },
        new double[] { 100, 200, 300 },
        "Actual: $0.00 | Expected: $0.00 | Matched: 0 | Short: 0 | Overpaid: 0 | Shortage: $0.00 | Overpayment: $0.00")]
    [InlineData(
        new double[] { 0, 0, 0 },
        new double[] { 0, 50, 0 },
        "Actual: $0.00 | Expected: $50.00 | Matched: 2 | Short: 1 | Overpaid: 0 | Shortage: $50.00 | Overpayment: $0.00")]
    [InlineData(
        new double[] { 500, -100, 250, 600 },
        new double[] { 400, 900, 300, 600 },
        "Actual: $1,350.00 | Expected: $1,300.00 | Matched: 1 | Short: 1 | Overpaid: 1 | Shortage: $50.00 | Overpayment: $100.00")]
    [InlineData(
        new double[] { },
        new double[] { },
        "Actual: $0.00 | Expected: $0.00 | Matched: 0 | Short: 0 | Overpaid: 0 | Shortage: $0.00 | Overpayment: $0.00")]
    public void CreateCashReceiptReconciliation_ReturnsExpectedReport(
        double[] actualValues,
        double[] expectedValues,
        string expected)
    {
        List<decimal> actualPayments =
            actualValues
                .Select(x => (decimal)x)
                .ToList();

        List<decimal> expectedPayments =
            expectedValues
                .Select(x => (decimal)x)
                .ToList();

        string actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise10.MainClass
                .CreateCashReceiptReconciliation(
                    actualPayments,
                    expectedPayments);

        Assert.Equal(expected, actual);
    }
}