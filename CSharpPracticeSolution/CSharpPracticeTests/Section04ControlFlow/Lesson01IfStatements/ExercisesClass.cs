namespace CSharpPracticeTests.Section04ControlFlow.Lesson01IfStatements;
[Trait("Section", "Section04ControlFlow")]
public class ExercisesClass
{
    [Theory]
    [InlineData(91, "Temperature warning")]
    [InlineData(105, "Temperature warning")]
    [InlineData(500, "Temperature warning")]
    [InlineData(90, "")]
    [InlineData(89, "")]
    [InlineData(0, "")]
    [InlineData(-10, "")]
    public void CheckHighTemperature_PrintsExpectedOutput(
       int temperature,
       string expected)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section04ControlFlow
            .Lesson01IfStatements.Exercise01.MainClass
            .CheckHighTemperature(temperature);

        string actual = writer.ToString().Trim();

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(0, "Low fuel")]
    [InlineData(5, "Low fuel")]
    [InlineData(9, "Low fuel")]
    [InlineData(10, "Low fuel")]
    [InlineData(11, "")]
    [InlineData(50, "")]
    [InlineData(100, "")]
    public void CheckFuelLevel_PrintsExpectedOutput(
        int fuelLevel,
        string expected)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section04ControlFlow
            .Lesson01IfStatements.Exercise02.MainClass
            .CheckFuelLevel(fuelLevel);

        string actual = writer.ToString().Trim();

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(51, 50, "Package is too heavy")]
    [InlineData(75, 50, "Package is too heavy")]
    [InlineData(101, 100, "Package is too heavy")]
    [InlineData(50, 50, "")]
    [InlineData(100, 100, "")]
    [InlineData(49, 50, "")]
    [InlineData(25, 50, "")]
    public void CheckPackageWeight_PrintsExpectedOutput(
        int packageWeight,
        int maximumWeight,
        string expected)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section04ControlFlow
            .Lesson01IfStatements.Exercise03.MainClass
            .CheckPackageWeight(packageWeight, maximumWeight);

        string actual = writer.ToString().Trim();

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5, 10, true, "Restock inventory")]
    [InlineData(9, 10, true, "Restock inventory")]
    [InlineData(0, 5, true, "Restock inventory")]
    [InlineData(10, 10, true, "")]
    [InlineData(11, 10, true, "")]
    [InlineData(5, 10, false, "")]
    [InlineData(20, 10, false, "")]
    public void CheckInventory_PrintsExpectedOutput(
        int availableItems,
        int minimumItems,
        bool automaticRestocking,
        string expected)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section04ControlFlow
            .Lesson01IfStatements.Exercise04.MainClass
            .CheckInventory(
                availableItems,
                minimumItems,
                automaticRestocking);

        string actual = writer.ToString().Trim();

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(500, 500, true, "Manual review required")]
    [InlineData(501, 500, true, "Manual review required")]
    [InlineData(1000, 500, true, "Manual review required")]
    [InlineData(200, 500, false, "Manual review required")]
    [InlineData(500, 500, false, "Manual review required")]
    [InlineData(499, 500, true, "")]
    [InlineData(200, 500, true, "")]
    public void CheckOrderForReview_PrintsExpectedOutput(
        int orderTotal,
        int reviewThreshold,
        bool paymentVerified,
        string expected)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section04ControlFlow
            .Lesson01IfStatements.Exercise05.MainClass
            .CheckOrderForReview(
                orderTotal,
                reviewThreshold,
                paymentVerified);

        string actual = writer.ToString().Trim();

        Assert.Equal(expected, actual);
    }
}