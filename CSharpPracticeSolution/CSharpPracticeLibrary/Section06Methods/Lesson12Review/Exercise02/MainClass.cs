/*
Enter the requirements for this exercise here.
A production system needs to calculate an adjusted production amount.

1. Create a public static method named CalculateAdjustedProduction.

   Parameters:
   - int baseProduction
   - int bonusProduction
   - int multiplier = 1

   Requirements:
   - Add baseProduction and bonusProduction together.
   - Multiply that result by multiplier.
   - Return the final integer result.

   The multiplier parameter MUST be optional with a default value of 1.
   Do not use method overloading to provide the default behavior.

2. Create a public static method named TryApplyProduction.

   Parameters:
   - ref int currentProduction
   - int amountToAdd
   - int maximumProduction

   Requirements:
   - If amountToAdd is negative, return false without changing
     currentProduction.
   - If adding amountToAdd would make currentProduction greater than
     maximumProduction, return false without changing currentProduction.
   - Otherwise, add amountToAdd to currentProduction and return true.

3. Create a public static method named IsProductionTargetReached.

   Parameters:
   - in int currentProduction
   - int targetProduction

   Requirements:
   - Return true when currentProduction is greater than or equal to
     targetProduction.
   - Otherwise, return false.
   - currentProduction MUST be an in parameter.
*/

namespace CSharpPracticeLibrary.Section06Methods.Lesson12Review.Exercise02;
public static class MainClass
{
    public static int CalculateAdjustedProduction(int baseProduction,
        int bonusProduction,
        int multiplier = 1
        )
    {
        int firsts = baseProduction + bonusProduction;
        return firsts * multiplier;
    }
    public static bool TryApplyProduction(ref int currentProduction,
        int amountToAdd,
        int maximumProduction
        )
    {
        if (amountToAdd < 0)
        {
            return false;
        }
        int possibleTotal = currentProduction + amountToAdd;
        if (possibleTotal > maximumProduction)
        {
            return false;
        }
        currentProduction = possibleTotal;
        return true;
    }
    public static bool IsProductionTargetReached(in int currentProduction,
        int targetProduction
        )
    {
        return currentProduction >= targetProduction;
    }
}