namespace CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise03;
public static class MainClass
{
    public static string CreateAssignment(
    string employeeName,
    int workstationNumber)
    {
        return $"{employeeName} assigned to workstation {workstationNumber}";
    }
    public static string CreateAssignment(
    int workstationNumber,
    string employeeName)
    {
        return $"Workstation {workstationNumber} assigned to {employeeName}";
    }
}