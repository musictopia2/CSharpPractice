using CSharpPracticeLibrary.Helpers;

namespace CSharpPracticeTests.Section05Loops.Lesson06NestedLoops;
[Trait("Section", "Section05Loops")]
public class ExercisesClass
{
    [Fact]
    public void DisplayStorageLocations_ShouldDisplayAllStorageLocations()
    {
        StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section05Loops.Lesson06NestedLoops.Exercise01
            .MainClass.DisplayStorageLocations();

        string expected =
            "Aisle 1 - Shelf 1\r\n" +
            "Aisle 1 - Shelf 2\r\n" +
            "Aisle 1 - Shelf 3\r\n" +
            "Aisle 1 - Shelf 4\r\n" +
            "Aisle 2 - Shelf 1\r\n" +
            "Aisle 2 - Shelf 2\r\n" +
            "Aisle 2 - Shelf 3\r\n" +
            "Aisle 2 - Shelf 4\r\n" +
            "Aisle 3 - Shelf 1\r\n" +
            "Aisle 3 - Shelf 2\r\n" +
            "Aisle 3 - Shelf 3\r\n" +
            "Aisle 3 - Shelf 4\r\n";

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void DisplayInspectionPoints_ShouldDisplayEveryMachineCheckpointCombination()
    {
        List<int> machines = [15, 30, 45];
        List<int> checkpoints = [3, 8];

        StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section05Loops.Lesson06NestedLoops.Exercise02
            .MainClass.DisplayInspectionPoints(machines, checkpoints);

        string expected =
            "Machine 15 - Checkpoint 3\r\n" +
            "Machine 15 - Checkpoint 8\r\n" +
            "Machine 30 - Checkpoint 3\r\n" +
            "Machine 30 - Checkpoint 8\r\n" +
            "Machine 45 - Checkpoint 3\r\n" +
            "Machine 45 - Checkpoint 8\r\n";

        Assert.Equal(expected, writer.ToString());
    }
    [Theory]
    [InlineData(3, 4, 12)]
    [InlineData(2, 5, 10)]
    [InlineData(1, 3, 3)]
    [InlineData(4, 1, 4)]
    public void CountDeliveryChecks_ShouldReturnTotalNumberOfChecks(
        int routeCount,
        int stopCount,
        int expected)
    {
        List<int> routes = [];
        List<int> stops = [];

        routeCount.Times(x => routes.Add(x));
        stopCount.Times(x => stops.Add(x));

        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson06NestedLoops.Exercise03
                .MainClass.CountDeliveryChecks(routes, stops);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(new int[] { 10, 20 }, new int[] { 3, 4, 6, 8 }, 4)]
    [InlineData(new int[] { 5, 15, 25 }, new int[] { 2, 3, 9 }, 6)]
    [InlineData(new int[] { 100 }, new int[] { 3, 6, 9, 12 }, 4)]
    [InlineData(new int[] { 10, 20, 30 }, new int[] { 1, 2, 4, 5 }, 0)]
    public void CountRequiredMaintenance_ShouldReturnCorrectNumberOfTasks(
        int[] machines,
        int[] maintenanceDays,
        int expected)
    {
        List<int> machineList = [.. machines];
        List<int> maintenanceDayList = [.. maintenanceDays];

        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson06NestedLoops.Exercise04
                .MainClass.CountRequiredMaintenance(
                    machineList,
                    maintenanceDayList);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(
        new int[] { 2, 5, 8 },
        new int[] { 1, 2, 5, 9 },
        2)]
    [InlineData(
        new int[] { 10, 20, 30 },
        new int[] { 5, 15, 25 },
        0)]
    [InlineData(
        new int[] { 4, 7, 12 },
        new int[] { 12, 7, 4 },
        3)]
    [InlineData(
        new int[] { 3, 6 },
        new int[] { 1, 2, 3, 4, 5, 6 },
        2)]
    public void CountMatchingAssignments_ShouldReturnNumberOfMatchingValues(
        int[] employeeNumbers,
        int[] stationNumbers,
        int expected)
    {
        List<int> employees = [.. employeeNumbers];
        List<int> stations = [.. stationNumbers];

        int actual =
            CSharpPracticeLibrary.Section05Loops.Lesson06NestedLoops.Exercise05
                .MainClass.CountMatchingAssignments(
                    employees,
                    stations);

        Assert.Equal(expected, actual);
    }
}