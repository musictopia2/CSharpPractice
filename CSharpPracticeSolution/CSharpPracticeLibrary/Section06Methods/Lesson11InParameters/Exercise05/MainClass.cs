/*
Enter the requirements for this exercise here.
The client says:

The shipment information must be passed using an in parameter because the method should only inspect it.
The total shipment weight consists of:
the combined weight of all packages;
plus the container weight.
The shipment can be loaded when its total weight is less than or equal to maximumWeight.
If it exceeds maximumWeight, it cannot be loaded.
The method must not modify any information in shipment.

For example, 10 packages weighing 4.5 each plus a container weighing 5 gives a total shipment weight of 50. Therefore, a vehicle with a maximum weight of 50 can carry it.
*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise05;
public static class MainClass
{
    public static bool CanLoadShipment(in ShipmentLoad shipment, double maximumWeight)
    {
        double totalsWeight =  shipment.WeightPerPackage * shipment.PackageCount;
        totalsWeight += shipment.ContainerWeight;
        return totalsWeight <= maximumWeight;
    }
}