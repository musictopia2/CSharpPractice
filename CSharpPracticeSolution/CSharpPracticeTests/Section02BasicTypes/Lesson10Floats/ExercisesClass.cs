namespace CSharpPracticeTests.Section02BasicTypes.Lesson10Floats;
[Trait("Section", "Section02BasicTypes")]
public class ExercisesClass
{
    [Fact]
    public void GetWalkingSpeed_ReturnsExpectedSpeed()
    {
        float result =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson10Floats.Exercise01.MainClass.GetWalkingSpeed();

        Assert.Equal(4.75f, result);
    }
    [Fact]
    public void GetDetectionRange_ReturnsExpectedRange()
    {
        float result =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson10Floats.Exercise02.MainClass.GetDetectionRange();

        Assert.Equal(125.5f, result);
    }
    [Fact]
    public void GetBlueIntensity_ReturnsExpectedIntensity()
    {
        float result =
            CSharpPracticeLibrary.Section02BasicTypes.Lesson10Floats.Exercise03.MainClass.GetBlueIntensity();

        Assert.Equal(0.875f, result);
    }
    [Fact]
    public void PrintMovementSetting_PrintsExpectedOutput()
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section02BasicTypes.Lesson10Floats.Exercise04.MainClass.PrintMovementSetting();

        string expected =
            $"Movement Type: Running{Environment.NewLine}" +
            $"Movement Speed: 6.25{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintCameraSettings_PrintsExpectedOutput()
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section02BasicTypes.Lesson10Floats.Exercise05.MainClass.PrintCameraSettings();

        string expected =
            $"Camera Zoom: 1.25{Environment.NewLine}" +
            $"Rotation Speed: 45.5{Environment.NewLine}";

        Assert.Equal(expected, writer.ToString());
    }
}