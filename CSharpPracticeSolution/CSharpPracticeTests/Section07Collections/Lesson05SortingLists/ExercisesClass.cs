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

    [Fact]
    public void Exercise02_ReverseReviewQueue_ReversesCurrentOrder()
    {
        List<int> accountNumbers = [610, 240, 890, 370];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise02.MainClass
            .ReverseReviewQueue(accountNumbers);

        Assert.Equal(new List<int> { 370, 890, 240, 610 }, result);
    }

    [Fact]
    public void Exercise02_ReverseReviewQueue_PreservesDuplicates()
    {
        List<int> accountNumbers = [320, 150, 320, 470, 150];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise02.MainClass
            .ReverseReviewQueue(accountNumbers);

        Assert.Equal(new List<int> { 150, 470, 320, 150, 320 }, result);
    }

    [Fact]
    public void Exercise02_ReverseReviewQueue_ModifiesOriginalList()
    {
        List<int> accountNumbers = [280, 940, 560];

        CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise02.MainClass
            .ReverseReviewQueue(accountNumbers);

        Assert.Equal(new List<int> { 560, 940, 280 }, accountNumbers);
    }

    [Fact]
    public void Exercise02_ReverseReviewQueue_ReturnsSameListInstance()
    {
        List<int> accountNumbers = [740, 190, 530];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise02.MainClass
            .ReverseReviewQueue(accountNumbers);

        Assert.Same(accountNumbers, result);
    }

    [Fact]
    public void Exercise02_ReverseReviewQueue_HandlesEmptyList()
    {
        List<int> accountNumbers = [];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise02.MainClass
            .ReverseReviewQueue(accountNumbers);

        Assert.NotNull(result);
        Assert.Empty(result);
        Assert.Same(accountNumbers, result);
    }

    [Fact]
    public void Exercise02_ReverseReviewQueue_HandlesSingleValue()
    {
        List<int> accountNumbers = [465];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise02.MainClass
            .ReverseReviewQueue(accountNumbers);

        Assert.Equal(new List<int> { 465 }, result);
        Assert.Same(accountNumbers, result);
    }

    [Fact]
    public void Exercise02_ReverseReviewQueue_HandlesTwoValues()
    {
        List<int> accountNumbers = [830, 210];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise02.MainClass
            .ReverseReviewQueue(accountNumbers);

        Assert.Equal(new List<int> { 210, 830 }, result);
    }

    [Fact]
    public void Exercise02_ReverseReviewQueue_PreservesNegativeValuesAndZero()
    {
        List<int> accountNumbers = [-30, 70, 0, -90, 20];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise02.MainClass
            .ReverseReviewQueue(accountNumbers);

        Assert.Equal(new List<int> { 20, -90, 0, 70, -30 }, result);
    }

    [Fact]
    public void Exercise02_ReverseReviewQueue_ReversingTwiceRestoresOriginalOrder()
    {
        List<int> accountNumbers = [680, 130, 920, 450];

        CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise02.MainClass
            .ReverseReviewQueue(accountNumbers);

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise02.MainClass
            .ReverseReviewQueue(accountNumbers);

        Assert.Equal(new List<int> { 680, 130, 920, 450 }, result);
        Assert.Same(accountNumbers, result);
    }
    [Fact]
    public void Exercise03_ArrangeTransactionAmounts_SortsAscendingWhenFalse()
    {
        List<int> amounts = [85, -30, 0, 45, 10];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise03.MainClass
            .ArrangeTransactionAmounts(amounts, largestFirst: false);

        Assert.Equal(new List<int> { -30, 0, 10, 45, 85 }, result);
    }

    [Fact]
    public void Exercise03_ArrangeTransactionAmounts_SortsDescendingWhenTrue()
    {
        List<int> amounts = [85, -30, 0, 45, 10];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise03.MainClass
            .ArrangeTransactionAmounts(amounts, largestFirst: true);

        Assert.Equal(new List<int> { 85, 45, 10, 0, -30 }, result);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise03_ArrangeTransactionAmounts_PreservesDuplicates(
        bool largestFirst)
    {
        List<int> amounts = [40, -15, 40, 0, -15];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise03.MainClass
            .ArrangeTransactionAmounts(amounts, largestFirst);

        List<int> expected = largestFirst
            ? [40, 40, 0, -15, -15]
            : [-15, -15, 0, 40, 40];

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise03_ArrangeTransactionAmounts_ModifiesOriginalList(
        bool largestFirst)
    {
        List<int> amounts = [35, 90, 20, 65];

        CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise03.MainClass
            .ArrangeTransactionAmounts(amounts, largestFirst);

        List<int> expected = largestFirst
            ? [90, 65, 35, 20]
            : [20, 35, 65, 90];

        Assert.Equal(expected, amounts);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise03_ArrangeTransactionAmounts_ReturnsSameListInstance(
        bool largestFirst)
    {
        List<int> amounts = [75, 20, 50];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise03.MainClass
            .ArrangeTransactionAmounts(amounts, largestFirst);

        Assert.Same(amounts, result);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise03_ArrangeTransactionAmounts_HandlesEmptyList(
        bool largestFirst)
    {
        List<int> amounts = [];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise03.MainClass
            .ArrangeTransactionAmounts(amounts, largestFirst);

        Assert.NotNull(result);
        Assert.Empty(result);
        Assert.Same(amounts, result);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise03_ArrangeTransactionAmounts_HandlesSingleValue(
        bool largestFirst)
    {
        List<int> amounts = [-25];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise03.MainClass
            .ArrangeTransactionAmounts(amounts, largestFirst);

        Assert.Equal(new List<int> { -25 }, result);
        Assert.Same(amounts, result);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise03_ArrangeTransactionAmounts_HandlesAllEqualValues(
        bool largestFirst)
    {
        List<int> amounts = [18, 18, 18];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise03.MainClass
            .ArrangeTransactionAmounts(amounts, largestFirst);

        Assert.Equal(new List<int> { 18, 18, 18 }, result);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise03_ArrangeTransactionAmounts_HandlesIntegerBoundaries(
        bool largestFirst)
    {
        List<int> amounts = [0, int.MaxValue, -1, int.MinValue, 1];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise03.MainClass
            .ArrangeTransactionAmounts(amounts, largestFirst);

        List<int> expected = largestFirst
            ? [int.MaxValue, 1, 0, -1, int.MinValue]
            : [int.MinValue, -1, 0, 1, int.MaxValue];

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Exercise03_ArrangeTransactionAmounts_CanChangeSortingDirection()
    {
        List<int> amounts = [55, -10, 80, 0];

        List<int> ascending = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise03.MainClass
            .ArrangeTransactionAmounts(amounts, largestFirst: false);

        Assert.Equal(new List<int> { -10, 0, 55, 80 }, ascending);

        List<int> descending = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise03.MainClass
            .ArrangeTransactionAmounts(amounts, largestFirst: true);

        Assert.Equal(new List<int> { 80, 55, 0, -10 }, descending);
        Assert.Same(amounts, ascending);
        Assert.Same(amounts, descending);
    }

    [Fact]
    public void Exercise04_SelectPaymentsForReview_SelectsLargestQualifyingPayments()
    {
        List<int> paymentAmounts = [55, 140, 85, 140, 25, 110];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(paymentAmounts, 80, 3);

        Assert.Equal(new List<int> { 140, 140, 110 }, result);
    }

    [Fact]
    public void Exercise04_SelectPaymentsForReview_IncludesMinimumAmount()
    {
        List<int> paymentAmounts = [49, 50, 75, 50, 20];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(paymentAmounts, 50, 10);

        Assert.Equal(new List<int> { 75, 50, 50 }, result);
    }

    [Fact]
    public void Exercise04_SelectPaymentsForReview_ReturnsAllWhenFewerQualify()
    {
        List<int> paymentAmounts = [20, 95, 40, 70];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(paymentAmounts, 60, 8);

        Assert.Equal(new List<int> { 95, 70 }, result);
    }

    [Fact]
    public void Exercise04_SelectPaymentsForReview_PreservesDuplicatesWithinLimit()
    {
        List<int> paymentAmounts = [90, 35, 90, 70, 90];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(paymentAmounts, 60, 2);

        Assert.Equal(new List<int> { 90, 90 }, result);
    }

    [Fact]
    public void Exercise04_SelectPaymentsForReview_MaximumOneReturnsLargest()
    {
        List<int> paymentAmounts = [65, 180, 95, 120];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(paymentAmounts, 60, 1);

        Assert.Equal(new List<int> { 180 }, result);
    }

    [Fact]
    public void Exercise04_SelectPaymentsForReview_ReturnsEmptyWhenNoneQualify()
    {
        List<int> paymentAmounts = [15, 45, 30];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(paymentAmounts, 50, 3);

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void Exercise04_SelectPaymentsForReview_ReturnsEmptyWhenMaximumIsZero()
    {
        List<int> paymentAmounts = [120, 60, 180];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(paymentAmounts, 50, 0);

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void Exercise04_SelectPaymentsForReview_HandlesEmptyInput()
    {
        List<int> paymentAmounts = [];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(paymentAmounts, 25, 4);

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Theory]
    [InlineData(40, 40, 1)]
    [InlineData(40, 41, 0)]
    public void Exercise04_SelectPaymentsForReview_HandlesSinglePayment(
        int amount,
        int minimumAmount,
        int expectedCount)
    {
        List<int> paymentAmounts = [amount];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(paymentAmounts, minimumAmount, 3);

        Assert.NotNull(result);
        Assert.Equal(expectedCount, result.Count);

        if (expectedCount == 1)
        {
            Assert.Equal(amount, result[0]);
        }
    }

    [Fact]
    public void Exercise04_SelectPaymentsForReview_HandlesNegativeAmountsAndMinimum()
    {
        List<int> paymentAmounts = [-50, 15, -10, 0, -25, -10];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(paymentAmounts, -25, 4);

        Assert.Equal(new List<int> { 15, 0, -10, -10 }, result);
    }

    [Fact]
    public void Exercise04_SelectPaymentsForReview_IncludesZeroAtZeroMinimum()
    {
        List<int> paymentAmounts = [-1, 0, 5, 0];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(paymentAmounts, 0, 10);

        Assert.Equal(new List<int> { 5, 0, 0 }, result);
    }

    [Theory]
    [InlineData(50, 3)]
    [InlineData(50, 0)]
    [InlineData(200, 3)]
    public void Exercise04_SelectPaymentsForReview_LeavesOriginalListUnchanged(
        int minimumAmount,
        int maximumCount)
    {
        List<int> paymentAmounts = [35, 110, 65, 110, 20, 85];

        CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(
                paymentAmounts,
                minimumAmount,
                maximumCount);

        Assert.Equal(
            new List<int> { 35, 110, 65, 110, 20, 85 },
            paymentAmounts);
    }

    [Fact]
    public void Exercise04_SelectPaymentsForReview_HandlesIntegerBoundaries()
    {
        List<int> paymentAmounts =
            [int.MinValue, 0, int.MaxValue, -1];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise04.MainClass
            .SelectPaymentsForReview(paymentAmounts, int.MinValue, 4);

        Assert.Equal(
            new List<int> { int.MaxValue, 0, -1, int.MinValue },
            result);
    }

    [Fact]
    public void Exercise05_BuildPaymentReviewBatch_SelectsLargestFirst()
    {
        List<int> pendingPayments = [35, 150, 80, 150, 25, 110];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 70, 3, true);

        Assert.Equal(new List<int> { 150, 150, 110 }, result);
        Assert.Equal(new List<int> { 35, 80, 25 }, pendingPayments);
    }

    [Fact]
    public void Exercise05_BuildPaymentReviewBatch_SelectsSmallestQualifyingFirst()
    {
        List<int> pendingPayments = [35, 150, 80, 150, 25, 110];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 70, 2, false);

        Assert.Equal(new List<int> { 80, 110 }, result);
        Assert.Equal(new List<int> { 35, 150, 150, 25 }, pendingPayments);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise05_BuildPaymentReviewBatch_IncludesMinimumAmount(
        bool largestFirst)
    {
        List<int> pendingPayments = [49, 50, 75, 50, 20];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 50, 10, largestFirst);

        List<int> expected = largestFirst
            ? [75, 50, 50]
            : [50, 50, 75];

        Assert.Equal(expected, result);
        Assert.Equal(new List<int> { 49, 20 }, pendingPayments);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise05_BuildPaymentReviewBatch_RemovesEarliestEqualPayment(
        bool largestFirst)
    {
        List<int> pendingPayments = [90, 20, 90, 30, 90];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 50, 1, largestFirst);

        Assert.Equal(new List<int> { 90 }, result);
        Assert.Equal(new List<int> { 20, 90, 30, 90 }, pendingPayments);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise05_BuildPaymentReviewBatch_RemovesExactlyTwoDuplicates(
        bool largestFirst)
    {
        List<int> pendingPayments = [90, 20, 90, 30, 90, 10];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 50, 2, largestFirst);

        Assert.Equal(new List<int> { 90, 90 }, result);
        Assert.Equal(new List<int> { 20, 30, 90, 10 }, pendingPayments);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise05_BuildPaymentReviewBatch_ReturnsAllWhenFewerQualify(
        bool largestFirst)
    {
        List<int> pendingPayments = [25, 85, 15, 65, 40];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 60, 8, largestFirst);

        List<int> expected = largestFirst
            ? [85, 65]
            : [65, 85];

        Assert.Equal(expected, result);
        Assert.Equal(new List<int> { 25, 15, 40 }, pendingPayments);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise05_BuildPaymentReviewBatch_LeavesBacklogWhenNoneQualify(
        bool largestFirst)
    {
        List<int> pendingPayments = [35, 10, 25];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 50, 3, largestFirst);

        Assert.NotNull(result);
        Assert.Empty(result);
        Assert.NotSame(pendingPayments, result);
        Assert.Equal(new List<int> { 35, 10, 25 }, pendingPayments);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise05_BuildPaymentReviewBatch_LeavesBacklogWhenMaximumIsZero(
        bool largestFirst)
    {
        List<int> pendingPayments = [120, 60, 180];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 50, 0, largestFirst);

        Assert.NotNull(result);
        Assert.Empty(result);
        Assert.NotSame(pendingPayments, result);
        Assert.Equal(new List<int> { 120, 60, 180 }, pendingPayments);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise05_BuildPaymentReviewBatch_HandlesEmptyBacklog(
        bool largestFirst)
    {
        List<int> pendingPayments = [];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 0, 5, largestFirst);

        Assert.NotNull(result);
        Assert.Empty(result);
        Assert.NotSame(pendingPayments, result);
        Assert.Empty(pendingPayments);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise05_BuildPaymentReviewBatch_HandlesSingleQualifyingPayment(
        bool largestFirst)
    {
        List<int> pendingPayments = [45];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 45, 3, largestFirst);

        Assert.Equal(new List<int> { 45 }, result);
        Assert.Empty(pendingPayments);
    }

    [Fact]
    public void Exercise05_BuildPaymentReviewBatch_HandlesNegativeMinimumAscending()
    {
        List<int> pendingPayments = [-40, 15, -10, 0, -25, -10];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, -25, 3, false);

        Assert.Equal(new List<int> { -25, -10, -10 }, result);
        Assert.Equal(new List<int> { -40, 15, 0 }, pendingPayments);
    }

    [Fact]
    public void Exercise05_BuildPaymentReviewBatch_HandlesNegativeMinimumDescending()
    {
        List<int> pendingPayments = [-40, 15, -10, 0, -25, -10];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, -25, 3, true);

        Assert.Equal(new List<int> { 15, 0, -10 }, result);
        Assert.Equal(new List<int> { -40, -25, -10 }, pendingPayments);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise05_BuildPaymentReviewBatch_IncludesZeroAtZeroMinimum(
        bool largestFirst)
    {
        List<int> pendingPayments = [-1, 0, 5, 0, -2];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 0, 10, largestFirst);

        List<int> expected = largestFirst
            ? [5, 0, 0]
            : [0, 0, 5];

        Assert.Equal(expected, result);
        Assert.Equal(new List<int> { -1, -2 }, pendingPayments);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise05_BuildPaymentReviewBatch_ReturnsIndependentList(
        bool largestFirst)
    {
        List<int> pendingPayments = [70, 20, 90];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 50, 2, largestFirst);

        Assert.NotSame(pendingPayments, result);
        Assert.Equal(new List<int> { 20 }, pendingPayments);

        result.Add(999);

        Assert.Equal(new List<int> { 20 }, pendingPayments);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Exercise05_BuildPaymentReviewBatch_HandlesIntegerBoundaries(
        bool largestFirst)
    {
        List<int> pendingPayments =
            [0, int.MinValue, int.MaxValue, -1, 1];

        List<int> result = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(
                pendingPayments,
                int.MinValue,
                int.MaxValue,
                largestFirst);

        List<int> expected = largestFirst
            ? [int.MaxValue, 1, 0, -1, int.MinValue]
            : [int.MinValue, -1, 0, 1, int.MaxValue];

        Assert.Equal(expected, result);
        Assert.Empty(pendingPayments);
    }

    [Fact]
    public void Exercise05_BuildPaymentReviewBatch_SupportsSuccessiveReviewSessions()
    {
        List<int> pendingPayments = [45, 120, 75, 120, 30, 95];

        List<int> firstBatch = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 70, 2, true);

        Assert.Equal(new List<int> { 120, 120 }, firstBatch);
        Assert.Equal(new List<int> { 45, 75, 30, 95 }, pendingPayments);

        List<int> secondBatch = CSharpPracticeLibrary.Section07Collections
            .Lesson05SortingLists.Exercise05.MainClass
            .BuildPaymentReviewBatch(pendingPayments, 40, 2, false);

        Assert.Equal(new List<int> { 45, 75 }, secondBatch);
        Assert.Equal(new List<int> { 30, 95 }, pendingPayments);

        Assert.Equal(new List<int> { 120, 120 }, firstBatch);
        Assert.NotSame(firstBatch, secondBatch);
    }

}