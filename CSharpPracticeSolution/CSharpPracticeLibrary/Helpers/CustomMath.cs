using System.Numerics;

namespace CSharpPracticeLibrary.Helpers;

public static class CustomMath
{
    extension<T>(T original)
        where T : INumber<T>
    {
        public T Remainder(T divider)
        {
            return original % divider;
        }
        public T LastDigit => original % T.CreateChecked(10);
    }
}