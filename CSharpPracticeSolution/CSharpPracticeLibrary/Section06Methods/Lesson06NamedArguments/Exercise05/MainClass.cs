namespace CSharpPracticeLibrary.Section06Methods.Lesson06NamedArguments.Exercise05;
public static class MainClass
{
    public static string CreateStorageRequest(
    string productName,
    int binNumber,
    int quantity,
    bool fragile)
    {
        return $"Product: {productName}, Bin: {binNumber}, Quantity: {quantity}, Fragile: {fragile}";
    }
    public static string PrepareStorageRequest()
    {
        string firsts = CreateStorageRequest(
            quantity: 8,
            fragile: true,
            productName: "Monitors",
            binNumber: 24
        );
        return firsts;
    }
}
/*
Client Requirements

PrepareStorageRequest must create a storage request for:

Product: "Monitors"
Bin number: 24
Quantity: 8
Fragile: true

The manager specifically wants the call to CreateStorageRequest to be readable without needing to remember its parameter order.

Therefore, call CreateStorageRequest using named arguments for all four arguments.

There is one additional requirement: arrange the named arguments in this order when making the call:

quantity
fragile
productName
binNumber

Return the result from CreateStorageRequest.
*/