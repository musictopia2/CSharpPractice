namespace CSharpPracticeTests.Integration01Sections01To06.Exercise07;
[Trait("Integration", "Integration01Sections01To0607")]
public class TestClass
{
    [Theory]
    [InlineData(
        new double[] { 500, 250, 0, -50, 400 },
        1150)]
    [InlineData(
        new double[] { 100, 200, 300 },
        600)]
    [InlineData(
        new double[] { 0, -25, -100 },
        0)]
    [InlineData(
        new double[] { },
        0)]
    public void CalculateTotalReceivables_ReturnsExpectedTotal(
        double[] balanceValues,
        decimal expected)
    {
        List<decimal> invoiceBalances =
            balanceValues
                .Select(x => (decimal)x)
                .ToList();

        decimal actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise07.MainClass
                .CalculateTotalReceivables(invoiceBalances);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(
        new double[] { 500, 250, 0, -50, 400 },
        new int[] { 15, 45, 90, 120, 75 },
        2)]
    [InlineData(
        new double[] { 100, 200, 300 },
        new int[] { 30, 31, 60 },
        2)]
    [InlineData(
        new double[] { 0, -50, 100 },
        new int[] { 100, 100, 10 },
        0)]
    [InlineData(
        new double[] { },
        new int[] { },
        0)]
    public void CountOverdueInvoices_ReturnsExpectedCount(
        double[] balanceValues,
        int[] dayValues,
        int expected)
    {
        List<decimal> invoiceBalances =
            balanceValues
                .Select(x => (decimal)x)
                .ToList();

        List<int> daysOutstanding = dayValues.ToList();

        int actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise07.MainClass
                .CountOverdueInvoices(invoiceBalances, daysOutstanding);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(
        new double[] { 500, 250, 0, -50, 400 },
        new int[] { 15, 45, 90, 120, 75 },
        650)]
    [InlineData(
        new double[] { 100, 200, 300 },
        new int[] { 30, 31, 60 },
        500)]
    [InlineData(
        new double[] { 0, -50, 100 },
        new int[] { 100, 100, 10 },
        0)]
    [InlineData(
        new double[] { },
        new int[] { },
        0)]
    public void CalculateOverdueReceivables_ReturnsExpectedTotal(
        double[] balanceValues,
        int[] dayValues,
        decimal expected)
    {
        List<decimal> invoiceBalances =
            balanceValues
                .Select(x => (decimal)x)
                .ToList();

        List<int> daysOutstanding = dayValues.ToList();

        decimal actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise07.MainClass
                .CalculateOverdueReceivables(invoiceBalances, daysOutstanding);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(
        new double[] { 500, 250, 0, -50, 400 },
        new int[] { 15, 45, 90, 120, 75 },
        75)]
    [InlineData(
        new double[] { 100, 200, 300 },
        new int[] { 10, 20, 30 },
        30)]
    [InlineData(
        new double[] { 0, -50, -100 },
        new int[] { 90, 120, 200 },
        0)]
    [InlineData(
        new double[] { 50, 0, 100 },
        new int[] { 200, 500, 150 },
        200)]
    [InlineData(
        new double[] { },
        new int[] { },
        0)]
    public void FindOldestUnpaidInvoiceDays_ReturnsExpectedDays(
        double[] balanceValues,
        int[] dayValues,
        int expected)
    {
        List<decimal> invoiceBalances =
            balanceValues
                .Select(x => (decimal)x)
                .ToList();

        List<int> daysOutstanding = dayValues.ToList();

        int actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise07.MainClass
                .FindOldestUnpaidInvoiceDays(
                    invoiceBalances,
                    daysOutstanding);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(
        new double[] { 500, 250, 0, -50, 400 },
        new int[] { 15, 45, 90, 120, 75 },
        "Total Receivables: $1,150.00 | Overdue Invoices: 2 | Overdue Receivables: $650.00 | Oldest Unpaid: 75 days")]
    [InlineData(
        new double[] { 100, 200, 300 },
        new int[] { 30, 31, 60 },
        "Total Receivables: $600.00 | Overdue Invoices: 2 | Overdue Receivables: $500.00 | Oldest Unpaid: 60 days")]
    [InlineData(
        new double[] { 0, -50, -100 },
        new int[] { 90, 120, 200 },
        "Total Receivables: $0.00 | Overdue Invoices: 0 | Overdue Receivables: $0.00 | Oldest Unpaid: 0 days")]
    [InlineData(
        new double[] { },
        new int[] { },
        "Total Receivables: $0.00 | Overdue Invoices: 0 | Overdue Receivables: $0.00 | Oldest Unpaid: 0 days")]
    public void CreateAccountsReceivableReport_ReturnsExpectedReport(
        double[] balanceValues,
        int[] dayValues,
        string expected)
    {
        List<decimal> invoiceBalances =
            balanceValues
                .Select(x => (decimal)x)
                .ToList();

        List<int> daysOutstanding = dayValues.ToList();

        string actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise07.MainClass
                .CreateAccountsReceivableReport(
                    invoiceBalances,
                    daysOutstanding);

        Assert.Equal(expected, actual);
    }
}