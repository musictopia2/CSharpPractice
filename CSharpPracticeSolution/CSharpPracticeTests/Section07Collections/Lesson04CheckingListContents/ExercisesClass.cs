namespace CSharpPracticeTests.Section07Collections.Lesson04CheckingListContents;
[Trait("Section", "Section07Collections")]
public class ExercisesClass
{
    [Theory]
    [InlineData("bolts", "Item found at index 0")]
    [InlineData("washers", "Item found at index 2")]
    [InlineData("hinges", "Item found at index 3")]
    [InlineData("paint", "Item not found")]
    public void LocateItem_ReturnsExpectedResult(
        string itemToFind,
        string expected)
    {
        List<string> inventoryItems =
        [
            "bolts",
            "screws",
            "washers",
            "hinges"
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise01.MainClass
                .LocateItem(inventoryItems, itemToFind);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LocateItem_DuplicateItem_ReturnsFirstIndex()
    {
        List<string> inventoryItems =
        [
            "bolts",
            "screws",
            "bolts",
            "washers"
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise01.MainClass
                .LocateItem(inventoryItems, "bolts");

        Assert.Equal("Item found at index 0", actual);
    }
    [Theory]
    [InlineData(105, "Stop is first")]
    [InlineData(210, "Stop is scheduled after 1 stops")]
    [InlineData(315, "Stop is scheduled after 2 stops")]
    [InlineData(420, "Stop is scheduled after 3 stops")]
    [InlineData(999, "Stop is not scheduled")]
    public void CheckDeliveryStop_ReturnsExpectedResult(
        int stopNumber,
        string expected)
    {
        List<int> scheduledStops =
        [
            105,
            210,
            315,
            420
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise02.MainClass
                .CheckDeliveryStop(scheduledStops, stopNumber);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckDeliveryStop_DuplicateStop_UsesFirstOccurrence()
    {
        List<int> scheduledStops =
        [
            105,
            210,
            315,
            210,
            420
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise02.MainClass
                .CheckDeliveryStop(scheduledStops, 210);

        Assert.Equal(
            "Stop is scheduled after 1 stops",
            actual);
    }
    [Theory]
    [InlineData(120, "Inspection scheduled early")]
    [InlineData(240, "Inspection scheduled early")]
    [InlineData(360, "Inspection scheduled middle")]
    [InlineData(480, "Inspection scheduled middle")]
    [InlineData(600, "Inspection scheduled late")]
    [InlineData(720, "Inspection scheduled late")]
    [InlineData(999, "Inspection not scheduled")]
    public void CheckInspectionPosition_ReturnsExpectedResult(
        int inspectionNumber,
        string expected)
    {
        List<int> inspectionNumbers =
        [
            120,
            240,
            360,
            480,
            600,
            720
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise03.MainClass
                .CheckInspectionPosition(
                    inspectionNumbers,
                    inspectionNumber);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckInspectionPosition_DuplicateInspection_UsesFirstOccurrence()
    {
        List<int> inspectionNumbers =
        [
            120,
            360,
            480,
            600,
            360
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise03.MainClass
                .CheckInspectionPosition(
                    inspectionNumbers,
                    360);

        Assert.Equal(
            "Inspection scheduled early",
            actual);
    }
    [Theory]
    [InlineData(410, 3, "Priority order at index 0")]
    [InlineData(275, 3, "Priority order at index 1")]
    [InlineData(830, 3, "Priority order at index 2")]
    [InlineData(625, 3, "Standard order at index 3")]
    [InlineData(190, 3, "Standard order at index 4")]
    [InlineData(999, 3, "Order not found")]
    public void CheckPriorityOrder_ReturnsExpectedResult(
        int orderNumber,
        int priorityCutoff,
        string expected)
    {
        List<int> orderNumbers =
        [
            410,
            275,
            830,
            625,
            190
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise04.MainClass
                .CheckPriorityOrder(
                    orderNumbers,
                    orderNumber,
                    priorityCutoff);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(410, 0, "Standard order at index 0")]
    [InlineData(410, 1, "Priority order at index 0")]
    [InlineData(830, 2, "Standard order at index 2")]
    [InlineData(830, 3, "Priority order at index 2")]
    public void CheckPriorityOrder_RespectsPriorityCutoffBoundary(
        int orderNumber,
        int priorityCutoff,
        string expected)
    {
        List<int> orderNumbers =
        [
            410,
            275,
            830,
            625,
            190
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise04.MainClass
                .CheckPriorityOrder(
                    orderNumbers,
                    orderNumber,
                    priorityCutoff);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckPriorityOrder_DuplicateOrder_UsesFirstOccurrence()
    {
        List<int> orderNumbers =
        [
            410,
            275,
            830,
            275,
            190
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise04.MainClass
                .CheckPriorityOrder(
                    orderNumbers,
                    275,
                    2);

        Assert.Equal(
            "Priority order at index 1",
            actual);
    }
    [Theory]
    [InlineData(4605, 3150, 3, "Urgent review: account 3150 at index 1")]
    [InlineData(7401, 9200, 2, "Urgent review: account 7401 at index 0")]
    [InlineData(8820, 4605, 2, "Standard review: account 8820 at index 2")]
    public void ChooseAccountForReview_BothAccountsExist_SelectsEarlierAccount(
        int firstAccount,
        int secondAccount,
        int urgentCutoff,
        string expected)
    {
        List<int> accountNumbers =
        [
            7401,
            3150,
            8820,
            4605,
            9200
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise05.MainClass
                .ChooseAccountForReview(
                    accountNumbers,
                    firstAccount,
                    secondAccount,
                    urgentCutoff);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(4605, 9999, 3, "Standard review: account 4605 at index 3")]
    [InlineData(9999, 3150, 3, "Urgent review: account 3150 at index 1")]
    public void ChooseAccountForReview_OneAccountExists_SelectsExistingAccount(
        int firstAccount,
        int secondAccount,
        int urgentCutoff,
        string expected)
    {
        List<int> accountNumbers =
        [
            7401,
            3150,
            8820,
            4605,
            9200
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise05.MainClass
                .ChooseAccountForReview(
                    accountNumbers,
                    firstAccount,
                    secondAccount,
                    urgentCutoff);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ChooseAccountForReview_NeitherAccountExists_ReturnsNoAccountsFound()
    {
        List<int> accountNumbers =
        [
            7401,
            3150,
            8820,
            4605,
            9200
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise05.MainClass
                .ChooseAccountForReview(
                    accountNumbers,
                    1111,
                    2222,
                    3);

        Assert.Equal("No accounts found", actual);
    }

    [Theory]
    [InlineData(3150, 3, "Urgent review: account 3150 at index 1")]
    [InlineData(3150, 1, "Standard review: account 3150 at index 1")]
    public void ChooseAccountForReview_SameAccountProvidedTwice_TreatsAsOneAccount(
        int accountNumber,
        int urgentCutoff,
        string expected)
    {
        List<int> accountNumbers =
        [
            7401,
            3150,
            8820,
            4605,
            9200
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise05.MainClass
                .ChooseAccountForReview(
                    accountNumbers,
                    accountNumber,
                    accountNumber,
                    urgentCutoff);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ChooseAccountForReview_DuplicateAccountInList_UsesFirstOccurrence()
    {
        List<int> accountNumbers =
        [
            7401,
            3150,
            8820,
            3150,
            9200
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise05.MainClass
                .ChooseAccountForReview(
                    accountNumbers,
                    3150,
                    8820,
                    2);

        Assert.Equal(
            "Urgent review: account 3150 at index 1",
            actual);
    }

    [Theory]
    [InlineData(7401, 0, "Standard review: account 7401 at index 0")]
    [InlineData(7401, 1, "Urgent review: account 7401 at index 0")]
    [InlineData(8820, 2, "Standard review: account 8820 at index 2")]
    [InlineData(8820, 3, "Urgent review: account 8820 at index 2")]
    public void ChooseAccountForReview_RespectsUrgentCutoffBoundary(
        int accountNumber,
        int urgentCutoff,
        string expected)
    {
        List<int> accountNumbers =
        [
            7401,
            3150,
            8820,
            4605,
            9200
        ];

        string actual =
            CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise05.MainClass
                .ChooseAccountForReview(
                    accountNumbers,
                    accountNumber,
                    9999,
                    urgentCutoff);

        Assert.Equal(expected, actual);
    }
}