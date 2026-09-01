namespace CSharpPracticeTests.Section05Loops.Lesson05ContinueStatement;
[Trait("Section", "Section05Loops")]
public class ExercisesClass
{
    [Fact]
    public void DisplayInspectionDays_SkipsMultiplesOfFour()
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            List<int> inspectionDays =
            [
                1, 2, 3, 4, 5, 6,
                7, 8, 9, 10, 11, 12
            ];

            CSharpPracticeLibrary.Section05Loops.Lesson05ContinueStatement
                .Exercise01.MainClass.DisplayInspectionDays(inspectionDays);

            string expected =
                $"1{Environment.NewLine}" +
                $"2{Environment.NewLine}" +
                $"3{Environment.NewLine}" +
                $"5{Environment.NewLine}" +
                $"6{Environment.NewLine}" +
                $"7{Environment.NewLine}" +
                $"9{Environment.NewLine}" +
                $"10{Environment.NewLine}" +
                $"11{Environment.NewLine}";

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Theory]
    [InlineData(new int[] { 3, 0, 7, -2, 9 }, "3|7|9")]
    [InlineData(new int[] { 1, 2, 3 }, "1|2|3")]
    [InlineData(new int[] { 0, -1, -5 }, "")]
    public void DisplayAvailableWorkstations_PrintsOnlyValidWorkstations(
    int[] workstationNumbers,
    string expectedValues)
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            List<int> workstations = workstationNumbers.ToList();

            CSharpPracticeLibrary.Section05Loops.Lesson05ContinueStatement
                .Exercise02.MainClass.DisplayAvailableWorkstations(workstations);

            string expected = string.Join(
                Environment.NewLine,
                expectedValues.Split(
                    '|',
                    StringSplitOptions.RemoveEmptyEntries));

            if (expected.Length > 0)
            {
                expected += Environment.NewLine;
            }

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Theory]
    [InlineData(new string[] { "Shipping", "", "Receiving", "", "Storage" },
    new string[] { "Shipping", "Receiving", "Storage" })]
    [InlineData(new string[] { "", "", "" },
    new string[] { })]
    [InlineData(new string[] { "Alpha", "Beta", "Gamma" },
    new string[] { "Alpha", "Beta", "Gamma" })]
    [InlineData(new string[] { "First", " ", "Last" },
    new string[] { "First", " ", "Last" })]
    public void DisplayLabels_PrintsLabelsExceptEmptyStrings(
    string[] labels,
    string[] expectedLabels)
    {
        TextWriter originalOutput = Console.Out;
        StringWriter writer = new();

        try
        {
            Console.SetOut(writer);

            List<string> input = labels.ToList();

            CSharpPracticeLibrary.Section05Loops.Lesson05ContinueStatement
                .Exercise03.MainClass.DisplayLabels(input);

            string expected = "";

            foreach (string label in expectedLabels)
            {
                expected += $"{label}{Environment.NewLine}";
            }

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOutput);
        }
    }
    [Theory]
    [InlineData(new int[] { 70, 25, 50, 40, 80 }, 200)]
    [InlineData(new int[] { 50 }, 50)]
    [InlineData(new int[] { 49, 20, -10, 0 }, 0)]
    [InlineData(new int[] { 100, 75, 50 }, 225)]
    [InlineData(new int[] { 49, 50, 51 }, 101)]
    public void CalculateQualifyingScoreTotal_ReturnsTotalOfQualifyingScores(
    int[] scores,
    int expected)
    {
        List<int> input = scores.ToList();

        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson05ContinueStatement
                .Exercise04.MainClass.CalculateQualifyingScoreTotal(input);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(new int[] { 25, 0, 40, -5, 15 }, 80)]
    [InlineData(new int[] { 10, 20, 30 }, 60)]
    [InlineData(new int[] { 0, -5, -20 }, 0)]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { -10, 50, 0, 25, -1, 100 }, 175)]
    public void CalculateShippedItems_ReturnsTotalOfUsableShipments(
    int[] shipmentQuantities,
    int expected)
    {
        List<int> input = shipmentQuantities.ToList();

        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson05ContinueStatement
                .Exercise05.MainClass.CalculateShippedItems(input);

        Assert.Equal(expected, actual);
    }
}