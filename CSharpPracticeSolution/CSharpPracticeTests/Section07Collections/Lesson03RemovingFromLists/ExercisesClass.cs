namespace CSharpPracticeTests.Section07Collections.Lesson03RemovingFromLists;
[Trait("Section", "Section07Collections")]
public class ExercisesClass
{
    [Theory]
    [InlineData("SH205")]
    [InlineData("SH100")]
    [InlineData("SH420")]
    public void RemoveShipment_RemovesExistingShipment(string shipmentToRemove)
    {
        List<string> shipments =
        [
            "SH100",
            "SH205",
            "SH310",
            "SH420"
        ];

        List<string> results =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise01.MainClass
                .RemoveShipment(shipments, shipmentToRemove);

        Assert.DoesNotContain(shipmentToRemove, results);
        Assert.Equal(3, results.Count);
    }

    [Fact]
    public void RemoveShipment_WhenShipmentDoesNotExist_LeavesListUnchanged()
    {
        List<string> shipments =
        [
            "SH100",
            "SH205",
            "SH310"
        ];

        List<string> expected =
        [
            "SH100",
            "SH205",
            "SH310"
        ];

        List<string> results =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise01.MainClass
                .RemoveShipment(shipments, "SH999");

        Assert.Equal(expected, results);
    }

    [Fact]
    public void RemoveShipment_WhenShipmentAppearsMoreThanOnce_RemovesOnlyFirstOccurrence()
    {
        List<string> shipments =
        [
            "SH100",
            "SH205",
            "SH310",
            "SH205"
        ];

        List<string> expected =
        [
            "SH100",
            "SH310",
            "SH205"
        ];

        List<string> results =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise01.MainClass
                .RemoveShipment(shipments, "SH205");

        Assert.Equal(expected, results);
    }
    [Theory]
    [InlineData("Warehouse", true)]
    [InlineData("Customer", true)]
    [InlineData("Fuel Stop", true)]
    [InlineData("Repair Shop", false)]
    public void CancelStop_ReturnsExpectedResult(
       string stopToCancel,
       bool expectedResult)
    {
        List<string> scheduledStops =
        [
            "Warehouse",
            "Customer",
            "Fuel Stop"
        ];

        bool result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise02.MainClass
                .CancelStop(scheduledStops, stopToCancel);

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CancelStop_WhenStopExists_RemovesItFromList()
    {
        List<string> scheduledStops =
        [
            "Warehouse",
            "Customer",
            "Fuel Stop"
        ];

        bool result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise02.MainClass
                .CancelStop(scheduledStops, "Customer");

        Assert.True(result);
        Assert.Equal(["Warehouse", "Fuel Stop"], scheduledStops);
    }

    [Fact]
    public void CancelStop_WhenStopDoesNotExist_LeavesListUnchanged()
    {
        List<string> scheduledStops =
        [
            "Warehouse",
            "Customer",
            "Fuel Stop"
        ];

        List<string> expected =
        [
            "Warehouse",
            "Customer",
            "Fuel Stop"
        ];

        bool result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise02.MainClass
                .CancelStop(scheduledStops, "Repair Shop");

        Assert.False(result);
        Assert.Equal(expected, scheduledStops);
    }

    [Fact]
    public void CancelStop_WhenStopAppearsMoreThanOnce_RemovesOnlyFirstOccurrence()
    {
        List<string> scheduledStops =
        [
            "Warehouse",
            "Customer",
            "Fuel Stop",
            "Customer"
        ];

        bool result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise02.MainClass
                .CancelStop(scheduledStops, "Customer");

        Assert.True(result);

        List<string> expected =
        [
            "Warehouse",
            "Fuel Stop",
            "Customer"
        ];

        Assert.Equal(expected, scheduledStops);
    }
    [Theory]
    [InlineData(0, "Inspect equipment")]
    [InlineData(1, "Load truck")]
    [InlineData(2, "Print report")]
    [InlineData(3, "Lock warehouse")]
    public void RemoveTask_ReturnsTaskAtSpecifiedIndex(
        int taskIndex,
        string expectedTask)
    {
        List<string> tasks =
        [
            "Inspect equipment",
            "Load truck",
            "Print report",
            "Lock warehouse"
        ];

        string result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise03.MainClass
                .RemoveTask(tasks, taskIndex);

        Assert.Equal(expectedTask, result);
    }

    [Fact]
    public void RemoveTask_RemovesTaskAtSpecifiedIndex()
    {
        List<string> tasks =
        [
            "Inspect equipment",
            "Load truck",
            "Print report",
            "Lock warehouse"
        ];

        string result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise03.MainClass
                .RemoveTask(tasks, 2);

        List<string> expected =
        [
            "Inspect equipment",
            "Load truck",
            "Lock warehouse"
        ];

        Assert.Equal("Print report", result);
        Assert.Equal(expected, tasks);
    }

    [Fact]
    public void RemoveTask_WhenRemovingFirstItem_ShiftsRemainingItems()
    {
        List<string> tasks =
        [
            "Inspect equipment",
            "Load truck",
            "Print report"
        ];

        string result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise03.MainClass
                .RemoveTask(tasks, 0);

        List<string> expected =
        [
            "Load truck",
            "Print report"
        ];

        Assert.Equal("Inspect equipment", result);
        Assert.Equal(expected, tasks);
    }

    [Fact]
    public void RemoveTask_WhenRemovingLastItem_LeavesEarlierItemsUnchanged()
    {
        List<string> tasks =
        [
            "Inspect equipment",
            "Load truck",
            "Print report"
        ];

        string result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise03.MainClass
                .RemoveTask(tasks, 2);

        List<string> expected =
        [
            "Inspect equipment",
            "Load truck"
        ];

        Assert.Equal("Print report", result);
        Assert.Equal(expected, tasks);
    }
    [Theory]
    [InlineData(0, 50, true)]
    [InlineData(1, 50, false)]
    [InlineData(2, 50, true)]
    public void RemoveRejectedReading_ReturnsExpectedResult(
       int inspectionIndex,
       int maximumAllowed,
       bool expectedResult)
    {
        List<int> readings =
        [
            75,
            40,
            90
        ];

        bool result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise04.MainClass
                .RemoveRejectedReading(
                    readings,
                    inspectionIndex,
                    maximumAllowed);

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RemoveRejectedReading_WhenInspectedReadingIsTooHigh_RemovesThatReading()
    {
        List<int> readings =
        [
            40,
            95,
            60,
            110
        ];

        bool result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise04.MainClass
                .RemoveRejectedReading(
                    readings,
                    1,
                    80);

        List<int> expected =
        [
            40,
            60,
            110
        ];

        Assert.True(result);
        Assert.Equal(expected, readings);
    }

    [Fact]
    public void RemoveRejectedReading_WhenInspectedReadingIsAllowed_LeavesListUnchanged()
    {
        List<int> readings =
        [
            40,
            70,
            95
        ];

        List<int> expected =
        [
            40,
            70,
            95
        ];

        bool result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise04.MainClass
                .RemoveRejectedReading(
                    readings,
                    1,
                    80);

        Assert.False(result);
        Assert.Equal(expected, readings);
    }

    [Fact]
    public void RemoveRejectedReading_OnlyConsidersSelectedIndex()
    {
        List<int> readings =
        [
            120,
            50,
            130
        ];

        List<int> expected =
        [
            120,
            50,
            130
        ];

        bool result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise04.MainClass
                .RemoveRejectedReading(
                    readings,
                    1,
                    80);

        Assert.False(
            result,
            "The selected reading is within the allowed range, so nothing should be removed.");

        Assert.Equal(expected, readings);
    }

    [Fact]
    public void RemoveRejectedReading_WhenValueEqualsMaximum_LeavesListUnchanged()
    {
        List<int> readings =
        [
            25,
            80,
            100
        ];

        bool result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise04.MainClass
                .RemoveRejectedReading(
                    readings,
                    1,
                    80);

        Assert.False(
            result,
            "A reading is rejected only when it is greater than the maximum.");

        Assert.Equal([25, 80, 100], readings);
    }
    [Theory]
    [InlineData(125, 50, 500, "Invoice accepted")]
    [InlineData(20, 50, 500, "Invoice removed")]
    [InlineData(900, 50, 500, "Invoice removed")]
    [InlineData(50, 50, 500, "Invoice accepted")]
    [InlineData(500, 50, 500, "Invoice accepted")]
    public void ReviewInvoice_ReturnsExpectedResult(
        decimal selectedAmount,
        decimal minimumAllowed,
        decimal maximumAllowed,
        string expectedResult)
    {
        List<decimal> invoiceAmounts =
        [
            100,
            selectedAmount,
            300
        ];

        string result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise05.MainClass
                .ReviewInvoice(
                    invoiceAmounts,
                    1,
                    minimumAllowed,
                    maximumAllowed);

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ReviewInvoice_WhenBelowMinimum_RemovesSelectedInvoice()
    {
        List<decimal> invoiceAmounts =
        [
            125,
            20,
            450,
            900
        ];

        string result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise05.MainClass
                .ReviewInvoice(
                    invoiceAmounts,
                    1,
                    50,
                    500);

        List<decimal> expected =
        [
            125,
            450,
            900
        ];

        Assert.Equal("Invoice removed", result);
        Assert.Equal(expected, invoiceAmounts);
    }

    [Fact]
    public void ReviewInvoice_WhenAboveMaximum_RemovesSelectedInvoice()
    {
        List<decimal> invoiceAmounts =
        [
            125,
            200,
            900,
            450
        ];

        string result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise05.MainClass
                .ReviewInvoice(
                    invoiceAmounts,
                    2,
                    50,
                    500);

        List<decimal> expected =
        [
            125,
            200,
            450
        ];

        Assert.Equal("Invoice removed", result);
        Assert.Equal(expected, invoiceAmounts);
    }

    [Fact]
    public void ReviewInvoice_WhenAccepted_LeavesListUnchanged()
    {
        List<decimal> invoiceAmounts =
        [
            125,
            450,
            900
        ];

        List<decimal> expected =
        [
            125,
            450,
            900
        ];

        string result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise05.MainClass
                .ReviewInvoice(
                    invoiceAmounts,
                    1,
                    50,
                    500);

        Assert.Equal("Invoice accepted", result);
        Assert.Equal(expected, invoiceAmounts);
    }

    [Theory]
    [InlineData(50)]
    [InlineData(500)]
    public void ReviewInvoice_WhenAmountEqualsBoundary_AcceptsInvoice(
        decimal selectedAmount)
    {
        List<decimal> invoiceAmounts =
        [
            125,
            selectedAmount,
            900
        ];

        string result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise05.MainClass
                .ReviewInvoice(
                    invoiceAmounts,
                    1,
                    50,
                    500);

        Assert.Equal(
            "Invoice accepted",
            result);

        Assert.Equal(
            [125, selectedAmount, 900],
            invoiceAmounts);
    }

    [Fact]
    public void ReviewInvoice_OnlyEvaluatesInvoiceAtReviewIndex()
    {
        List<decimal> invoiceAmounts =
        [
            10,
            250,
            900
        ];

        List<decimal> expected =
        [
            10,
            250,
            900
        ];

        string result =
            CSharpPracticeLibrary.Section07Collections.Lesson03RemovingFromLists.Exercise05.MainClass
                .ReviewInvoice(
                    invoiceAmounts,
                    1,
                    50,
                    500);

        Assert.Equal(
            "Invoice accepted",
            result);

        Assert.Equal(
            expected,
            invoiceAmounts);
    }
}