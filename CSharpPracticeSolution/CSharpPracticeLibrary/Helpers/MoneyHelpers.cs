namespace CSharpPracticeLibrary.Helpers;

public static class MoneyHelpers
{
    extension(decimal amount)
    {
        public string ToCurrency()
        {
            return $"${amount:N2}";
        }
    }
}