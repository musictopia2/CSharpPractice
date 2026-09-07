/*
Enter the requirements for this exercise here.
Use this namespace:

namespace CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise01;

Create a MainClass with this method:

public static decimal CalculateShipmentValue(in Shipment shipment)

Create this value type:

public struct Shipment
{
    public decimal ItemPrice;
    public int Quantity;
}
Requirements

CalculateShipmentValue must:

Receive the Shipment using an in parameter.
Calculate the shipment's total value by multiplying ItemPrice by Quantity.
Return the calculated value as a decimal.
Treat the supplied shipment as read-only. Do not modify either of its fields.
*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson11InParameters.Exercise01;
public static class MainClass
{
    public static decimal CalculateShipmentValue(in Shipment shipment)
    {
        return shipment.ItemPrice * shipment.Quantity;
    }
}