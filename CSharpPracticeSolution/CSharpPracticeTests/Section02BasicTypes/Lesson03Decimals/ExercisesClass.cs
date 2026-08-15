namespace CSharpPracticeTests.Section02BasicTypes.Lesson03Decimals;
[Trait("Section", "Section02BasicTypes")]
public class ExercisesClass
{
    [Theory]
    [InlineData("125.50", "24.50", "150.00")]
    [InlineData("0.00", "18.75", "18.75")]
    [InlineData("49.99", "0.01", "50.00")]
    [InlineData("250.75", "100.25", "351.00")]
    [InlineData("10.10", "20.20", "30.30")]
    public void CalculateBalance_ReturnsCorrectBalance(
        string currentBalanceText,
        string depositAmountText,
        string expectedText)
    {
        decimal currentBalance = decimal.Parse(currentBalanceText);
        decimal depositAmount = decimal.Parse(depositAmountText);
        decimal expected = decimal.Parse(expectedText);

        decimal actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson03Decimals.Exercise01
                .MainClass.CalculateBalance(currentBalance, depositAmount);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("50.00", "12.75", "37.25")]
    [InlineData("100.00", "40.50", "59.50")]
    [InlineData("25.00", "25.00", "0.00")]
    [InlineData("200.99", "50.49", "150.50")]
    [InlineData("10.50", "0.25", "10.25")]
    public void CalculateRemainingBalance_ReturnsCorrectBalance(
        string giftCardBalanceText,
        string purchaseAmountText,
        string expectedText)
    {
        decimal giftCardBalance = decimal.Parse(giftCardBalanceText);
        decimal purchaseAmount = decimal.Parse(purchaseAmountText);
        decimal expected = decimal.Parse(expectedText);

        decimal actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson03Decimals.Exercise02
                .MainClass.CalculateRemainingBalance(
                    giftCardBalance,
                    purchaseAmount);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("12.50", "3", "37.50")]
    [InlineData("4.25", "2", "8.50")]
    [InlineData("9.99", "1", "9.99")]
    [InlineData("15.75", "4", "63.00")]
    [InlineData("2.50", "10", "25.00")]
    public void CalculateOrderCost_ReturnsCorrectTotal(
        string itemPriceText,
        string quantityText,
        string expectedText)
    {
        decimal itemPrice = decimal.Parse(itemPriceText);
        decimal quantity = decimal.Parse(quantityText);
        decimal expected = decimal.Parse(expectedText);

        decimal actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson03Decimals.Exercise03
                .MainClass.CalculateOrderCost(itemPrice, quantity);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("60.00", "4", "15.00")]
    [InlineData("37.50", "3", "12.50")]
    [InlineData("99.90", "10", "9.99")]
    [InlineData("45.00", "2", "22.50")]
    [InlineData("125.00", "5", "25.00")]
    public void CalculatePricePerTicket_ReturnsCorrectPrice(
        string totalCostText,
        string ticketCountText,
        string expectedText)
    {
        decimal totalCost = decimal.Parse(totalCostText);
        decimal ticketCount = decimal.Parse(ticketCountText);
        decimal expected = decimal.Parse(expectedText);

        decimal actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson03Decimals.Exercise04
                .MainClass.CalculatePricePerTicket(totalCost, ticketCount);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("10.00", "3", "5.00", "35.00")]
    [InlineData("7.50", "4", "2.99", "32.99")]
    [InlineData("19.99", "2", "0.00", "39.98")]
    [InlineData("12.25", "5", "4.75", "66.00")]
    [InlineData("3.50", "10", "8.25", "43.25")]
    public void CalculateInvoiceTotal_ReturnsCorrectTotal(
        string itemPriceText,
        string quantityText,
        string shippingCostText,
        string expectedText)
    {
        decimal itemPrice = decimal.Parse(itemPriceText);
        decimal quantity = decimal.Parse(quantityText);
        decimal shippingCost = decimal.Parse(shippingCostText);
        decimal expected = decimal.Parse(expectedText);

        decimal actual =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson03Decimals.Exercise05
                .MainClass.CalculateInvoiceTotal(
                    itemPrice,
                    quantity,
                    shippingCost);

        Assert.Equal(expected, actual);
    }
}