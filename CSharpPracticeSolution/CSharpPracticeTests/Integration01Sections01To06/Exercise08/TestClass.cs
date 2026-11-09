namespace CSharpPracticeTests.Integration01Sections01To06.Exercise08;
[Trait("Integration", "Integration01Sections01To0608")]
public class TestClass
{
    [Theory]
    [InlineData(new double[] { 500, 1500, -50, 0, 800, 1200 }, 4000)]
    [InlineData(new double[] { 100, 200, 300 }, 600)]
    [InlineData(new double[] { -100, 0, -50 }, 0)]
    [InlineData(new double[] { }, 0)]
    public void CalculateTotalExpenses_ReturnsExpectedTotal(
        double[] expenseValues,
        decimal expected)
    {
        List<decimal> expenses =
            expenseValues
                .Select(x => (decimal)x)
                .ToList();

        decimal actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise08.MainClass
                .CalculateTotalExpenses(expenses);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new double[] { 500, 1500, -50, 0, 800, 1200 }, 1000, 2)]
    [InlineData(new double[] { 100, 200, 300 }, 200, 1)]
    [InlineData(new double[] { 100, 200, 300 }, 300, 0)]
    [InlineData(new double[] { -100, 0, -50 }, 100, 0)]
    [InlineData(new double[] { }, 100, 0)]
    public void CountExpensesOverLimit_ReturnsExpectedCount(
        double[] expenseValues,
        decimal reviewLimit,
        int expected)
    {
        List<decimal> expenses =
            expenseValues
                .Select(x => (decimal)x)
                .ToList();

        int actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise08.MainClass
                .CountExpensesOverLimit(expenses, reviewLimit);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new double[] { 500, 1500, -50, 0, 800, 1200 }, 1500)]
    [InlineData(new double[] { 100, 200, 300 }, 300)]
    [InlineData(new double[] { -100, 0, -50 }, 0)]
    [InlineData(new double[] { 0, 75, 25 }, 75)]
    [InlineData(new double[] { }, 0)]
    public void FindLargestExpense_ReturnsExpectedExpense(
        double[] expenseValues,
        decimal expected)
    {
        List<decimal> expenses =
            expenseValues
                .Select(x => (decimal)x)
                .ToList();

        decimal actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise08.MainClass
                .FindLargestExpense(expenses);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(4000, 3200, 800)]
    [InlineData(4000, 4000, 0)]
    [InlineData(4000, 4500, -500)]
    [InlineData(1000, 0, 1000)]
    public void CalculateRemainingBudget_ReturnsExpectedBalance(
        decimal monthlyBudget,
        decimal totalExpenses,
        decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise08.MainClass
                .CalculateRemainingBudget(monthlyBudget, totalExpenses);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(500, "Under Budget")]
    [InlineData(0, "Budget Met")]
    [InlineData(-500, "Over Budget")]
    public void GetBudgetStatus_ReturnsExpectedStatus(
        decimal remainingBudget,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise08.MainClass
                .GetBudgetStatus(remainingBudget);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(
        4000,
        new double[] { 500, 1500, -50, 0, 800, 1200 },
        1000,
        "Status: Budget Met | Expenses: $4,000.00 | Remaining: $0.00 | Over Limit: 2 | Largest: $1,500.00")]
    [InlineData(
        5000,
        new double[] { 500, 1000, 750 },
        800,
        "Status: Under Budget | Expenses: $2,250.00 | Remaining: $2,750.00 | Over Limit: 1 | Largest: $1,000.00")]
    [InlineData(
        1000,
        new double[] { 600, 700 },
        500,
        "Status: Over Budget | Expenses: $1,300.00 | Remaining: $-300.00 | Over Limit: 2 | Largest: $700.00")]
    [InlineData(
        1000,
        new double[] { -100, 0 },
        500,
        "Status: Under Budget | Expenses: $0.00 | Remaining: $1,000.00 | Over Limit: 0 | Largest: $0.00")]
    [InlineData(
        0,
        new double[] { },
        100,
        "Status: Budget Met | Expenses: $0.00 | Remaining: $0.00 | Over Limit: 0 | Largest: $0.00")]
    public void CreateMonthlyBudgetReport_ReturnsExpectedReport(
        decimal monthlyBudget,
        double[] expenseValues,
        decimal reviewLimit,
        string expected)
    {
        List<decimal> expenses =
            expenseValues
                .Select(x => (decimal)x)
                .ToList();

        string actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise08.MainClass
                .CreateMonthlyBudgetReport(
                    monthlyBudget,
                    expenses,
                    reviewLimit);

        Assert.Equal(expected, actual);
    }
}