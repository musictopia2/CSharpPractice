namespace CSharpPracticeLibrary.Helpers;
public static class LoopHelpers
{
    extension(int howMany)
    {
        public void Times(Action<int> action)
        {
            for (int i = 0; i < howMany; i++)
            {
                action?.Invoke(i + 1);
            }
        }
        public void Times(Action action)
        {
            for (int i = 0; i < howMany; i++)
            {
                action?.Invoke();
            }
        }
        public void Times(Action<int> action, int skipBy)
        {
            for (int i = 0; i < howMany; i+= skipBy)
            {
                action?.Invoke(i + skipBy);
            }
        }
    }
}