/*
Enter the requirements for this exercise here.
CalculateUsableUnits must:

Receive production using an in parameter.
Subtract DefectiveUnits from UnitsProduced.
Return the number of usable units.
Not modify production.

MeetsTarget must:

Receive the same ProductionData using an in parameter.
Use CalculateUsableUnits to obtain the number of usable units.
Return true when the usable units are greater than or equal to target.
Otherwise, return false.
Not modify production.
*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise04;
public static class MainClass
{
    public static int CalculateUsableUnits(in ProductionData production)
    {
        return production.UnitsProduced - production.DefectiveUnits;
    }
    public static bool MeetsTarget(in ProductionData production, int target)
    {
        int produced = CalculateUsableUnits(production);
        return produced >= target;
    }
}
