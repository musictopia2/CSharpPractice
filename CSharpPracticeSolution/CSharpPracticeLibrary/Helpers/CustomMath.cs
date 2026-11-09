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

        public T Percentage
        {
            get
            {
                if (original < T.Zero)
                {
                    return T.Zero;
                }
                T maximum = T.CreateChecked(100);
                if (original > maximum)
                {
                    return maximum;
                }
                return original;
            }
        }


    }
    
}