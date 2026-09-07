namespace CSharpPracticeTests.Section06Methods.Lesson07OptionalParameters;
[Trait("Section", "Section06Methods")]
public class ExercisesClass
{
    [Fact]
    public void CreateShippingLabel_WhenShippingTypeIsOmitted_UsesStandard()
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise01.MainClass
                .CreateShippingLabel("Denver");

        Assert.Equal("Shipping to Denver - Standard", actual);
    }

    [Theory]
    [InlineData("Phoenix", "Express", "Shipping to Phoenix - Express")]
    [InlineData("Seattle", "Priority", "Shipping to Seattle - Priority")]
    [InlineData("Boston", "Overnight", "Shipping to Boston - Overnight")]
    public void CreateShippingLabel_WhenShippingTypeIsProvided_UsesProvidedValue(
        string destination,
        string shippingType,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise01.MainClass
                .CreateShippingLabel(destination, shippingType);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("Morgan", "Reservation for Morgan - Party of 2")]
    [InlineData("Jordan", "Reservation for Jordan - Party of 2")]
    [InlineData("Casey", "Reservation for Casey - Party of 2")]
    public void Exercise02_CreateReservationMessage_UsesDefaultPartySize(
    string customerName,
    string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise02.MainClass
                .CreateReservationMessage(customerName);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Taylor", 6, "Reservation for Taylor - Party of 6")]
    [InlineData("Alex", 1, "Reservation for Alex - Party of 1")]
    [InlineData("Jamie", 12, "Reservation for Jamie - Party of 12")]
    public void Exercise02_CreateReservationMessage_UsesProvidedPartySize(
        string customerName,
        int partySize,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise02.MainClass
                .CreateReservationMessage(customerName, partySize);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("Laptops", "Laptops: 1 available at Main Warehouse")]
    [InlineData("Printers", "Printers: 1 available at Main Warehouse")]
    public void Exercise03_CreateInventoryNotice_UsesBothDefaults(
    string itemName,
    string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise03.MainClass
                .CreateInventoryNotice(itemName);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Monitors", 8, "Monitors: 8 available at Main Warehouse")]
    [InlineData("Mice", 20, "Mice: 20 available at Main Warehouse")]
    public void Exercise03_CreateInventoryNotice_UsesProvidedQuantity(
        string itemName,
        int quantity,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise03.MainClass
                .CreateInventoryNotice(itemName, quantity);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Keyboards", 15, "North Warehouse",
        "Keyboards: 15 available at North Warehouse")]
    [InlineData("Cables", 40, "South Warehouse",
        "Cables: 40 available at South Warehouse")]
    public void Exercise03_CreateInventoryNotice_UsesAllProvidedArguments(
        string itemName,
        int quantity,
        string location,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise03.MainClass
                .CreateInventoryNotice(itemName, quantity, location);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(25.00, 4, 100.00)]
    [InlineData(18.50, 3, 55.50)]
    [InlineData(42.25, 2, 84.50)]
    public void Exercise04_CalculateServiceTotal_UsesDefaultAdditionalFee(
    decimal hourlyRate,
    int hoursWorked,
    decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise04.MainClass
                .CalculateServiceTotal(hourlyRate, hoursWorked);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(25.00, 4, 15.00, 115.00)]
    [InlineData(18.50, 3, 12.25, 67.75)]
    [InlineData(42.25, 2, 20.50, 105.00)]
    public void Exercise04_CalculateServiceTotal_UsesProvidedAdditionalFee(
        decimal hourlyRate,
        int hoursWorked,
        decimal additionalFee,
        decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise04.MainClass
                .CalculateServiceTotal(hourlyRate, hoursWorked, additionalFee);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5, 5)]
    [InlineData(2, 2)]
    [InlineData(10, 10)]
    public void Exercise05_CalculateDeliveryDays_UsesDefaultDelay(
    int standardDays,
    int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise05.MainClass
                .CalculateDeliveryDays(standardDays);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 3, 8)]
    [InlineData(2, 1, 3)]
    [InlineData(10, 5, 15)]
    public void Exercise05_CalculateDeliveryDays_UsesProvidedDelay(
        int standardDays,
        int delayDays,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson07OptionalParameters.Exercise05.MainClass
                .CalculateDeliveryDays(standardDays, delayDays);

        Assert.Equal(expected, actual);
    }

}