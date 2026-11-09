namespace CSharpPracticeTests.Section07Collections.Lesson01CreatingLists;
[Trait("Section", "Section07Collections")]
public class ExercisesClass
{
    [Fact]
    public void PrintDepartments_ShouldPrintAllDepartmentsInOrder()
    {
        // Arrange
        StringWriter writer = new();
        TextWriter originalOutput = Console.Out;
        Console.SetOut(writer);

        try
        {
            // Act
            CSharpPracticeLibrary.Section07Collections
                .Lesson01CreatingLists.Exercise01.MainClass.PrintDepartments();

            // Assert
            string expected =
                $"Accounting{Environment.NewLine}" +
                $"Shipping{Environment.NewLine}" +
                $"Support{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void PrintSupplyItems_ShouldPrintAllItemsInOrder()
    {
        // Arrange
        StringWriter writer = new();
        TextWriter originalOutput = Console.Out;
        Console.SetOut(writer);

        try
        {
            // Act
            CSharpPracticeLibrary.Section07Collections
                .Lesson01CreatingLists.Exercise02.MainClass.PrintSupplyItems();

            // Assert
            string expected =
                $"Boxes{Environment.NewLine}" +
                $"Labels{Environment.NewLine}" +
                $"Tape{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void CreatePriorityLevels_ShouldReturnExpectedPriorityLevels()
    {
        // Act
        List<int> actual =
            CSharpPracticeLibrary.Section07Collections
                .Lesson01CreatingLists.Exercise03.MainClass.CreatePriorityLevels();

        // Assert
        List<int> expected =
            [
                10,
                20,
                30,
                40
            ];

        Assert.Equal(expected, actual);
    }
    [Fact]
    public void PrintLargeOrders_ShouldPrintOnlyQuantitiesAtLeast20()
    {
        // Arrange
        StringWriter writer = new();
        TextWriter originalOutput = Console.Out;
        Console.SetOut(writer);

        try
        {
            // Act
            CSharpPracticeLibrary.Section07Collections
                .Lesson01CreatingLists.Exercise04.MainClass.PrintLargeOrders();

            // Assert
            string expected =
                $"35{Environment.NewLine}" +
                $"50{Environment.NewLine}" +
                $"21{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Fact]
    public void CreateProcessingQueue_ShouldReturnRequiredDocumentTypesInOrder()
    {
        // Act
        List<string> actual =
            CSharpPracticeLibrary.Section07Collections
                .Lesson01CreatingLists.Exercise05.MainClass.CreateProcessingQueue();

        // Assert
        List<string> expected =
            [
                "Invoices",
                "Payments",
                "Adjustments"
            ];

        Assert.Equal(expected, actual);
    }
}