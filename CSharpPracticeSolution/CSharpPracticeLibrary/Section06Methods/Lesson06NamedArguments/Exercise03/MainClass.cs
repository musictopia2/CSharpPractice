namespace CSharpPracticeLibrary.Section06Methods.Lesson06NamedArguments.Exercise03;
public static class MainClass
{
    public static string CreateMachineReport(
    string machineName,
    int inspectionCount,
    bool needsRepair)
    {
        return $"Machine: {machineName}, Inspections: {inspectionCount}, Needs Repair: {needsRepair}";
    }
    public static string GetMachineReport(int scenario)
    {
        if (scenario == 1)
        {
            return CreateMachineReport(machineName: "Press", inspectionCount: 4, needsRepair: false);
        }
        if (scenario == 2)
        {
            return CreateMachineReport(needsRepair: true, inspectionCount: 7, machineName: "Welder");
        }
        if (scenario == 3)
        {
            return CreateMachineReport(inspectionCount: 2, machineName: "Drill", needsRepair: false);
        }
        if (scenario == 4)
        {
            return CreateMachineReport(needsRepair: true, machineName: "Lathe", inspectionCount: 6);
        }

        return "Invalid scenario";
    }
}