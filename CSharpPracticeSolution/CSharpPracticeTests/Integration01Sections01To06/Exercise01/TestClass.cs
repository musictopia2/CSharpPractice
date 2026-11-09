namespace CSharpPracticeTests.Integration01Sections01To06.Exercise01;
[Trait("Integration", "Integration01Sections01To0601")]
public class TestClass
{
    [Theory]
    [InlineData(800, 10, 720)]
    [InlineData(500, -10, 500)]
    [InlineData(500, 120, 0)]
    [InlineData(500, 0, 500)]
    [InlineData(500, 100, 0)]
    [InlineData(250, 20, 200)]
    [InlineData(0, 25, 0)]
    [InlineData(-100, 10, 0)]
    public void CalculateInvoiceTotal_ReturnsExpectedTotal(
        decimal subtotal,
        decimal discountPercent,
        decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Integration01Sections01To06.Exercise01.MainClass
                .CalculateInvoiceTotal(subtotal, discountPercent);

        Assert.Equal(expected, actual);
    }
}