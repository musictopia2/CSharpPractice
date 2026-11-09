namespace CSharpPracticeTests.Section07Collections.Lesson05SortingLists;
[Trait("Section", "Section07Collections")]
public class ExercisesClass
{
    [Fact]
    public void Exercise01_ArrangeInvoiceNumbers_SortsUnorderedValues()
    {
        List<int> invoiceNumbers = [640, 120, 850, 310];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise01.MainClass
            .ArrangeInvoiceNumbers(invoiceNumbers);

        Assert.Equal(new List<int> { 120, 310, 640, 850 }, result);
    }

    [Fact]
    public void Exercise01_ArrangeInvoiceNumbers_PreservesDuplicates()
    {
        List<int> invoiceNumbers = [420, 180, 420, 180, 290];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise01.MainClass
            .ArrangeInvoiceNumbers(invoiceNumbers);

        Assert.Equal(new List<int> { 180, 180, 290, 420, 420 }, result);
    }

    [Fact]
    public void Exercise01_ArrangeInvoiceNumbers_ModifiesOriginalList()
    {
        List<int> invoiceNumbers = [900, 600, 300];

        CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise01.MainClass
            .ArrangeInvoiceNumbers(invoiceNumbers);

        Assert.Equal(new List<int> { 300, 600, 900 }, invoiceNumbers);
    }

    [Fact]
    public void Exercise01_ArrangeInvoiceNumbers_ReturnsSameListInstance()
    {
        List<int> invoiceNumbers = [510, 230, 780];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise01.MainClass
            .ArrangeInvoiceNumbers(invoiceNumbers);

        Assert.Same(invoiceNumbers, result);
    }

    [Fact]
    public void Exercise01_ArrangeInvoiceNumbers_HandlesEmptyList()
    {
        List<int> invoiceNumbers = [];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise01.MainClass
            .ArrangeInvoiceNumbers(invoiceNumbers);

        Assert.NotNull(result);
        Assert.Empty(result);
        Assert.Same(invoiceNumbers, result);
    }

    [Fact]
    public void Exercise01_ArrangeInvoiceNumbers_HandlesSingleValue()
    {
        List<int> invoiceNumbers = [375];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise01.MainClass
            .ArrangeInvoiceNumbers(invoiceNumbers);

        Assert.Equal(new List<int> { 375 }, result);
    }

    [Fact]
    public void Exercise01_ArrangeInvoiceNumbers_PreservesAscendingOrder()
    {
        List<int> invoiceNumbers = [110, 220, 330, 440];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise01.MainClass
            .ArrangeInvoiceNumbers(invoiceNumbers);

        Assert.Equal(new List<int> { 110, 220, 330, 440 }, result);
    }

    [Fact]
    public void Exercise01_ArrangeInvoiceNumbers_HandlesNegativeValuesAndZero()
    {
        List<int> invoiceNumbers = [25, -40, 0, -10, 15];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise01.MainClass
            .ArrangeInvoiceNumbers(invoiceNumbers);

        Assert.Equal(new List<int> { -40, -10, 0, 15, 25 }, result);
    }

    [Fact]
    public void Exercise01_ArrangeInvoiceNumbers_HandlesIntegerBoundaries()
    {
        List<int> invoiceNumbers = [int.MaxValue, 0, int.MinValue];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise01.MainClass
            .ArrangeInvoiceNumbers(invoiceNumbers);

        Assert.Equal(
            new List<int> { int.MinValue, 0, int.MaxValue },
            result);
    }
}