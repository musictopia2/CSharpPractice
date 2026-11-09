/*
Enter the requirements for this exercise here.
Client Requirement

An accounting department keeps account numbers in the order they are scheduled for review.

The client provides two account numbers and wants the system to decide which one should be reviewed first.

Use the first occurrence of each account number in the list.

Your solution must meaningfully use both Contains() and IndexOf().

The rules are:

If neither account exists, return exactly:
No accounts found
If only one account exists, return:
Review account X at index Y

where X is the account number and Y is its index.

If both accounts exist, choose whichever has the lower index.
If both inputs contain the same account number, treat that as one account rather than two separate choices.

There is also an urgency rule.

If the selected account's index is less than urgentCutoff, return:

Urgent review: account X at index Y

Otherwise return:

Standard review: account X at index Y
Example

Given:

List<int> accountNumbers =
[
    7401,
    3150,
    8820,
    4605,
    9200
];

For:

firstAccount = 4605
secondAccount = 3150
urgentCutoff = 3

the result should be:

Urgent review: account 3150 at index 1

because both accounts exist, but 3150 appears earlier.
*/

namespace CSharpPracticeLibrary.Section07Collections.Lesson04CheckingListContents.Exercise05;
public static class MainClass
{
    public static string ChooseAccountForReview(
    List<int> accountNumbers,
    int firstAccount,
    int secondAccount,
    int urgentCutoff)
    {
        bool firstFound = accountNumbers.Contains(firstAccount);
        bool secondFound = accountNumbers.Contains(secondAccount);
        int realAccount;
        if (firstFound == false && secondFound == false)
        {
            return "No accounts found";
        }
        if (firstFound != secondFound)
        {
            int onlyAccountIndex;

            if (firstFound)
            {
                onlyAccountIndex = accountNumbers.IndexOf(firstAccount);
                realAccount = firstAccount;
            }
            else
            {
                onlyAccountIndex = accountNumbers.IndexOf(secondAccount);
                realAccount = secondAccount;
            }
            if (onlyAccountIndex < urgentCutoff)
            {
                return $"Urgent review: account {realAccount} at index {onlyAccountIndex}";
            }
            return $"Standard review: account {realAccount} at index {onlyAccountIndex}";
        }
        int firstIndex = accountNumbers.IndexOf(firstAccount);
        int secondIndex = accountNumbers.IndexOf(secondAccount);
        int realIndex;
        if (firstIndex <= secondIndex)
        {
            realIndex = firstIndex;
            realAccount = firstAccount;
        }
        else
        {
            realIndex = secondIndex;
            realAccount = secondAccount;
        }
        if (realIndex < urgentCutoff)
        {
            return $"Urgent review: account {realAccount} at index {realIndex}";
        }
        return $"Standard review: account {realAccount} at index {realIndex}";
    }
}