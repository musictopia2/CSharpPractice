namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson03ElseIfChains.Exercise02;
public static class MainClass
{
    public static string GetPackageDescription(int weight)
    {
        string firstDescription;
        if (weight >= 50)
        {
            firstDescription = "Heavy";
        }
        else if (weight >= 25)
        {
            firstDescription = "Medium";
        }
        else if (weight >= 10)
        {
            firstDescription = "Light";
        }
        else
        {
            firstDescription = "Small";
        }
        return $"{firstDescription} Package";
    }
}