namespace CSharpPracticeLibrary.Section06Methods.Lesson05MethodOverloading.Exercise02;
public static class MainClass
{
    public static string CreateLabel(int id)
    {
        return $"ID: {id}";
    }
    public static string CreateLabel(string name)
    {
        return $"Name: {name}";
    }
}