namespace CSharpPracticeTests.Section06Methods.Lesson05MethodOverloading;
[Trait("Section", "Section06Methods")]
public class ExercisesClass
{
    [Theory]
    [InlineData(12, 8, 20)]
    [InlineData(0, 15, 15)]
    [InlineData(25, 30, 55)]
    [InlineData(-5, 10, 5)]
    public void CalculateItems_WithTwoGroups_ReturnsTotal(
       int firstGroup,
       int secondGroup,
       int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise01.MainClass.CalculateItems(
                firstGroup,
                secondGroup);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(10, 20, 30, 60)]
    [InlineData(0, 5, 10, 15)]
    [InlineData(15, 25, 35, 75)]
    [InlineData(-10, 5, 20, 15)]
    public void CalculateItems_WithThreeGroups_ReturnsTotal(
        int firstGroup,
        int secondGroup,
        int thirdGroup,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise01.MainClass.CalculateItems(
                firstGroup,
                secondGroup,
                thirdGroup);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(25, "ID: 25")]
    [InlineData(0, "ID: 0")]
    [InlineData(731, "ID: 731")]
    [InlineData(-12, "ID: -12")]
    public void CreateLabel_WithInteger_ReturnsIdLabel(
       int id,
       string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise02.MainClass.CreateLabel(
                id);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Morgan", "Name: Morgan")]
    [InlineData("Taylor", "Name: Taylor")]
    [InlineData("Alex", "Name: Alex")]
    [InlineData("", "Name: ")]
    public void CreateLabel_WithString_ReturnsNameLabel(
        string name,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise02.MainClass.CreateLabel(
                name);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData("Morgan", 12, "Morgan assigned to workstation 12")]
    [InlineData("Taylor", 5, "Taylor assigned to workstation 5")]
    [InlineData("Alex", 0, "Alex assigned to workstation 0")]
    public void CreateAssignment_WithNameFirst_ReturnsExpectedAssignment(
       string employeeName,
       int workstationNumber,
       string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise03.MainClass.CreateAssignment(
                employeeName,
                workstationNumber);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(12, "Morgan", "Workstation 12 assigned to Morgan")]
    [InlineData(5, "Taylor", "Workstation 5 assigned to Taylor")]
    [InlineData(0, "Alex", "Workstation 0 assigned to Alex")]
    public void CreateAssignment_WithWorkstationFirst_ReturnsExpectedAssignment(
        int workstationNumber,
        string employeeName,
        string expected)
    {
        string actual =
            CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise03.MainClass.CreateAssignment(
                workstationNumber,
                employeeName);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5, 8, 40)]
    [InlineData(10, 3, 30)]
    [InlineData(1, 25, 25)]
    [InlineData(0, 12, 0)]
    public void CalculateShippingWeight_WithoutContainer_ReturnsPackageWeight(
        int packageCount,
        int weightPerPackage,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise04.MainClass.CalculateShippingWeight(
                packageCount,
                weightPerPackage);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 8, 12, 52)]
    [InlineData(10, 3, 20, 50)]
    [InlineData(1, 25, 5, 30)]
    [InlineData(0, 12, 15, 15)]
    public void CalculateShippingWeight_WithContainer_ReturnsTotalWeight(
        int packageCount,
        int weightPerPackage,
        int containerWeight,
        int expected)
    {
        int actual =
            CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise04.MainClass.CalculateShippingWeight(
                packageCount,
                weightPerPackage,
                containerWeight);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(3, 40.00, 120.00)]
    [InlineData(5, 25.50, 127.50)]
    [InlineData(1, 75.25, 75.25)]
    [InlineData(0, 50.00, 0.00)]
    public void CalculateServiceCost_WithoutParts_ReturnsLaborCost(
        int hoursWorked,
        decimal hourlyRate,
        decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise05.MainClass.CalculateServiceCost(
                hoursWorked,
                hourlyRate);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(3, 40.00, 35.50, 155.50)]
    [InlineData(5, 25.50, 20.25, 147.75)]
    [InlineData(1, 75.25, 10.00, 85.25)]
    [InlineData(0, 50.00, 45.75, 45.75)]
    public void CalculateServiceCost_WithParts_ReturnsLaborAndPartsCost(
        int hoursWorked,
        decimal hourlyRate,
        decimal partsCost,
        decimal expected)
    {
        decimal actual =
            CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise05.MainClass.CalculateServiceCost(
                hoursWorked,
                hourlyRate,
                partsCost);

        Assert.Equal(expected, actual);
    }

}