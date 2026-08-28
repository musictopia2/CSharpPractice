namespace CSharpPracticeLibrary.Section03Operators.Lesson11LogicalOr.Exercise01;
public static class MainClass
{
    public static bool CanCheckoutEquipment(int membershipLevel, bool hasStaffApproval)
    {
        return membershipLevel >= 3 || hasStaffApproval;
    }
}