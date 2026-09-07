namespace CSharpPracticeTests.Section06Methods.Lesson01VoidMethods;
[Trait("Section", "Section06Methods")]
public class ExercisesClass
{
    [Fact]
    public void DisplayNotice_PrintsExpectedNotice()
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise01.MainClass.DisplayNotice();

        string output = writer.ToString().Trim();

        Assert.Equal("System is ready.", output);
    }

    [Fact]
    public void PrintNotice_IsPrivateStaticVoidMethod()
    {
        Type type = typeof(
            CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise01.MainClass);

        System.Reflection.MethodInfo? method = type.GetMethod(
            "PrintNotice",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Static);

        Assert.NotNull(method);
        Assert.True(method.IsPrivate);
        Assert.True(method.IsStatic);
        Assert.Equal(typeof(void), method.ReturnType);
    }

    [Fact]
    public void DisplayNotice_IsPublicStaticVoidMethod()
    {
        Type type = typeof(
            CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise01.MainClass);

        System.Reflection.MethodInfo? method = type.GetMethod(
            "DisplayNotice",
            System.Reflection.BindingFlags.Public |
            System.Reflection.BindingFlags.Static);

        Assert.NotNull(method);
        Assert.True(method.IsPublic);
        Assert.True(method.IsStatic);
        Assert.Equal(typeof(void), method.ReturnType);
    }
    [Fact]
    public void ShowMaintenanceMessage_PrintsExpectedMessage()
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise02.MainClass.ShowMaintenanceMessage();

        string output = writer.ToString().Trim();

        Assert.Equal("Maintenance check started.", output);
    }

    [Fact]
    public void PrintMaintenanceMessage_IsPrivateStaticVoidMethod()
    {
        Type type = typeof(
            CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise02.MainClass);

        System.Reflection.MethodInfo? method = type.GetMethod(
            "PrintMaintenanceMessage",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Static);

        Assert.NotNull(method);
        Assert.True(method.IsPrivate);
        Assert.True(method.IsStatic);
        Assert.Equal(typeof(void), method.ReturnType);
    }

    [Fact]
    public void ShowMaintenanceMessage_IsPublicStaticVoidMethod()
    {
        Type type = typeof(
            CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise02.MainClass);

        System.Reflection.MethodInfo? method = type.GetMethod(
            "ShowMaintenanceMessage",
            System.Reflection.BindingFlags.Public |
            System.Reflection.BindingFlags.Static);

        Assert.NotNull(method);
        Assert.True(method.IsPublic);
        Assert.True(method.IsStatic);
        Assert.Equal(typeof(void), method.ReturnType);
    }
    [Theory]
    [InlineData(7)]
    [InlineData(1)]
    [InlineData(25)]
    [InlineData(100)]
    public void DisplayProductionStatus_PrintsMachineNumberAndReadyMessage(
        int machineNumber)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise03.MainClass
            .DisplayProductionStatus(machineNumber);

        string expected =
            $"Machine {machineNumber}{Environment.NewLine}" +
            "Ready for production.";

        string output = writer.ToString().Trim();

        Assert.Equal(expected, output);
    }

    [Fact]
    public void PrintReadyMessage_IsPrivateStaticVoidMethod()
    {
        Type type = typeof(
            CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise03.MainClass);

        System.Reflection.MethodInfo? method = type.GetMethod(
            "PrintReadyMessage",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Static);

        Assert.NotNull(method);
        Assert.True(method.IsPrivate);
        Assert.True(method.IsStatic);
        Assert.Equal(typeof(void), method.ReturnType);
    }

    [Fact]
    public void DisplayProductionStatus_HasRequiredSignature()
    {
        Type type = typeof(
            CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise03.MainClass);

        System.Reflection.MethodInfo? method = type.GetMethod(
            "DisplayProductionStatus",
            System.Reflection.BindingFlags.Public |
            System.Reflection.BindingFlags.Static);

        Assert.NotNull(method);
        Assert.True(method.IsPublic);
        Assert.True(method.IsStatic);
        Assert.Equal(typeof(void), method.ReturnType);

        System.Reflection.ParameterInfo[] parameters = method.GetParameters();

        Assert.Single(parameters);
        Assert.Equal(typeof(int), parameters[0].ParameterType);
    }
    [Theory]
    [InlineData(1)]
    [InlineData(6)]
    [InlineData(10)]
    public void PrepareShipment_WhenPackageCountIsTenOrLess_PrintsOnlyPackageCount(
        int packageCount)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise04.MainClass
            .PrepareShipment(packageCount);

        string expected = $"Packages: {packageCount}";

        string output = writer.ToString().Trim();

        Assert.Equal(expected, output);
    }

    [Theory]
    [InlineData(11)]
    [InlineData(12)]
    [InlineData(25)]
    public void PrepareShipment_WhenPackageCountIsGreaterThanTen_PrintsWarning(
        int packageCount)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise04.MainClass
            .PrepareShipment(packageCount);

        string expected =
            $"Packages: {packageCount}{Environment.NewLine}" +
            "Large shipment requires inspection.";

        string output = writer.ToString().Trim();

        Assert.Equal(expected, output);
    }

    [Fact]
    public void PrintLargeShipmentWarning_IsPrivateStaticVoidMethod()
    {
        Type type = typeof(
            CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise04.MainClass);

        System.Reflection.MethodInfo? method = type.GetMethod(
            "PrintLargeShipmentWarning",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Static);

        Assert.NotNull(method);
        Assert.True(method.IsPrivate);
        Assert.True(method.IsStatic);
        Assert.Equal(typeof(void), method.ReturnType);
    }

    [Fact]
    public void PrepareShipment_HasRequiredSignature()
    {
        Type type = typeof(
            CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise04.MainClass);

        System.Reflection.MethodInfo? method = type.GetMethod(
            "PrepareShipment",
            System.Reflection.BindingFlags.Public |
            System.Reflection.BindingFlags.Static);

        Assert.NotNull(method);
        Assert.True(method.IsPublic);
        Assert.True(method.IsStatic);
        Assert.Equal(typeof(void), method.ReturnType);

        System.Reflection.ParameterInfo[] parameters = method.GetParameters();

        Assert.Single(parameters);
        Assert.Equal(typeof(int), parameters[0].ParameterType);
    }
    [Theory]
    [InlineData("Press A")]
    [InlineData("Cutter 4")]
    [InlineData("Packaging Line")]
    public void StartMachine_WhenSafetyCheckPassed_PrintsStartedMessage(
        string machineName)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise05.MainClass
            .StartMachine(machineName, true);

        string expected =
            $"Starting: {machineName}{Environment.NewLine}" +
            "Machine started.";

        string output = writer.ToString().Trim();

        Assert.Equal(expected, output);
    }

    [Theory]
    [InlineData("Press A")]
    [InlineData("Cutter 4")]
    [InlineData("Packaging Line")]
    public void StartMachine_WhenSafetyCheckFailed_PrintsBlockedMessage(
        string machineName)
    {
        using StringWriter writer = new();
        Console.SetOut(writer);

        CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise05.MainClass
            .StartMachine(machineName, false);

        string expected =
            $"Starting: {machineName}{Environment.NewLine}" +
            "Startup blocked.";

        string output = writer.ToString().Trim();

        Assert.Equal(expected, output);
    }

    [Theory]
    [InlineData("PrintStartedMessage")]
    [InlineData("PrintBlockedMessage")]
    public void StatusMessageMethod_IsPrivateStaticVoidMethod(
        string methodName)
    {
        Type type = typeof(
            CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise05.MainClass);

        System.Reflection.MethodInfo? method = type.GetMethod(
            methodName,
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Static);

        Assert.NotNull(method);
        Assert.True(method.IsPrivate);
        Assert.True(method.IsStatic);
        Assert.Equal(typeof(void), method.ReturnType);
        Assert.Empty(method.GetParameters());
    }

    [Fact]
    public void StartMachine_HasRequiredSignature()
    {
        Type type = typeof(
            CSharpPracticeLibrary.Section06Methods.Lesson01VoidMethods.Exercise05.MainClass);

        System.Reflection.MethodInfo? method = type.GetMethod(
            "StartMachine",
            System.Reflection.BindingFlags.Public |
            System.Reflection.BindingFlags.Static);

        Assert.NotNull(method);
        Assert.True(method.IsPublic);
        Assert.True(method.IsStatic);
        Assert.Equal(typeof(void), method.ReturnType);

        System.Reflection.ParameterInfo[] parameters = method.GetParameters();

        Assert.Equal(2, parameters.Length);
        Assert.Equal(typeof(string), parameters[0].ParameterType);
        Assert.Equal(typeof(bool), parameters[1].ParameterType);
    }


}