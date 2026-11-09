using System.Numerics;
namespace CSharpPracticeLibrary.Helpers;

public static class AdvancedLinq
{
    extension<T>(List<T> values)
        where T : INumber<T>
    {


        public T SumWhere(Predicate<T> condition)
        {

            T total = T.Zero;

            foreach (T value in values)
            {
                if (condition(value))
                {
                    total += value;
                }
            }

            return total;
        }
        public void ForConditionalItems(Predicate<T> condition, Action<T> action)
        {
            foreach (var value in values)
            {
                if (condition(value))
                {
                    action.Invoke(value);
                }
            }
        }
    }
}
