namespace CSharpPracticeLibrary.Section06Methods.Lesson06NamedArguments.Exercise01;
public static class MainClass
{
    public static string CallWithNamedArguments(int scenario)
    {
        if (scenario == 1)
        {
            return CreateShipmentLabel(destination: "Phoenix", packageCount: 3, priority: false);
        }
        if (scenario == 2)
        {
            return CreateShipmentLabel(priority: true, packageCount: 6, destination: "Seattle");
        }
        if (scenario == 3)
        {
            return CreateShipmentLabel("Boston", packageCount: 2, priority: true);
        }
        if (scenario == 4)
        {
            return CreateShipmentLabel("Dallas", 5, priority: false);
        }

        return "Invalid scenario";
    }
    public static string CreateShipmentLabel(
    string destination,
    int packageCount,
    bool priority)
    {
        return $"Destination: {destination}, Packages: {packageCount}, Priority: {priority}";
    }
}