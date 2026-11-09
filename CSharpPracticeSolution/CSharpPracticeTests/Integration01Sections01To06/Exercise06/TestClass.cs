namespace CSharpPracticeTests.Integration01Sections01To06.Exercise06;
[Trait("Integration", "Integration01Sections01To0606")]
public class TestClass
{
    [Theory]
    [InlineData(
        new double[] { 250, -20, 500, 900, 50 },
        500,
        800)]
    [InlineData(
        new double[] { 100, 200, 300 },
        300,
        600)]
    [InlineData(
        new double[] { -10, 0, 500 },
        100,
        0)]
    [InlineData(
        new double[] { },
        500,
        0)]
    public void CalculateApprovedExpenses_ReturnsExpectedTotal(
        double[] expenseValues,
        decimal maximumSingleExpense,
        decimal expected)
    {
        List<decimal> expenses =
            expenseValues
                .Select(x => (decimal)x)
                .ToList();

        decimal actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise06.MainClass
                .CalculateApprovedExpenses(expenses, maximumSingleExpense);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(
        new double[] { 250, -20, 500, 900, 50 },
        500,
        2)]
    [InlineData(
        new double[] { 100, 200, 300 },
        300,
        0)]
    [InlineData(
        new double[] { -10, 0, 500 },
        100,
        3)]
    [InlineData(
        new double[] { },
        500,
        0)]
    public void CountRejectedExpenses_ReturnsExpectedCount(
        double[] expenseValues,
        decimal maximumSingleExpense,
        int expected)
    {
        List<decimal> expenses =
            expenseValues
                .Select(x => (decimal)x)
                .ToList();

        int actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise06.MainClass
                .CountRejectedExpenses(expenses, maximumSingleExpense);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(800, 75, 600)]
    [InlineData(800, 80, 640)]
    [InlineData(800, 0, 0)]
    [InlineData(800, -25, 0)]
    [InlineData(800, 125, 800)]
    [InlineData(0, 50, 0)]
    public void CalculateReimbursement_ReturnsExpectedAmount(
        decimal approvedExpenses,
        decimal reimbursementPercent,
        decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise06.MainClass
                .CalculateReimbursement(approvedExpenses, reimbursementPercent);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(
        new double[] { 250, -20, 500, 900, 50 },
        500,
        80,
        "Approved: $800.00 | Rejected: 2 | Reimbursement: $640.00")]
    [InlineData(
        new double[] { 100, 200, 300 },
        300,
        50,
        "Approved: $600.00 | Rejected: 0 | Reimbursement: $300.00")]
    [InlineData(
        new double[] { -10, 0, 500 },
        100,
        75,
        "Approved: $0.00 | Rejected: 3 | Reimbursement: $0.00")]
    [InlineData(
        new double[] { 400, 600 },
        500,
        150,
        "Approved: $400.00 | Rejected: 1 | Reimbursement: $400.00")]
    public void CreateReimbursementSummary_ReturnsExpectedSummary(
        double[] expenseValues,
        decimal maximumSingleExpense,
        decimal reimbursementPercent,
        string expected)
    {
        List<decimal> expenses =
            expenseValues
                .Select(x => (decimal)x)
                .ToList();

        string actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise06.MainClass
                .CreateReimbursementSummary(
                    expenses,
                    maximumSingleExpense,
                    reimbursementPercent);

        Assert.Equal(expected, actual);
    }
}