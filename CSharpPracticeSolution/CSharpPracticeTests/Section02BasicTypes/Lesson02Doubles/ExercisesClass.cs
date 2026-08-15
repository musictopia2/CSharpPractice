namespace CSharpPracticeTests.Section02BasicTypes.Lesson02Doubles;
[Trait("Section", "Section02BasicTypes")]
public class ExercisesClass
{
    [Fact]
    public void GetPackageWeight_ReturnsExpectedWeight()
    {
        // Act
        double result =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson02Doubles.Exercise01
                .MainClass.GetPackageWeight();

        // Assert
        Assert.Equal(12.75, result);
    }
    [Fact]
    public void GetFuelAmount_ReturnsExpectedAmount()
    {
        // Act
        double result =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson02Doubles.Exercise02
                .MainClass.GetFuelAmount();

        // Assert
        Assert.Equal(8.625, result);
    }
    [Fact]
    public void GetTemperatureChange_ReturnsExpectedChange()
    {
        // Act
        double result =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson02Doubles.Exercise03
                .MainClass.GetTemperatureChange();

        // Assert
        Assert.Equal(-6.25, result);
    }
    [Fact]
    public void GetCombinedWeight_ReturnsExpectedCombinedWeight()
    {
        // Act
        double result =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson02Doubles.Exercise04
                .MainClass.GetCombinedWeight();

        // Assert
        Assert.Equal(7.25, result);
    }
    [Fact]
    public void GetTargetTemperature_ReturnsExpectedTemperature()
    {
        // Act
        double result =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson02Doubles.Exercise05
                .MainClass.GetTargetTemperature();

        // Assert
        Assert.Equal(3.75, result);
    }
}