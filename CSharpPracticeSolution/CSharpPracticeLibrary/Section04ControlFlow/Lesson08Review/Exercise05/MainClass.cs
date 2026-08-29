namespace CSharpPracticeLibrary.Section04ControlFlow.Lesson08Review.Exercise05;
public static class MainClass
{
    public static string GetServiceAction(
    int serviceCode,
    bool isEmergency,
    bool isContractCustomer)
    {
        if (serviceCode is >= 1 and <= 4)
        {
            if (isEmergency)
            {
                return "Emergency Dispatch";
            }
            if (serviceCode == 3)
            {
                return "Inspection";
            }
            if (serviceCode == 4)
            {
                return "Replacement";
            }
            if (isContractCustomer)
            {
                return "Contract Repair";
            }
            
            return "Standard Repair";
        }
        return "Invalid Service";
    }
}
/*
The client has given you these rules:

Valid service codes are 1 through 4. Anything else must return "Invalid Service".
An emergency request always returns "Emergency Dispatch" once the service code has been confirmed as valid.
Service codes 1 and 2 are normal repair services.
Contract customers return "Contract Repair".
Other customers return "Standard Repair".
Service code 3 returns "Inspection".
Service code 4 returns "Replacement".
*/