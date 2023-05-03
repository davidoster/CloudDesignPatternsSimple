namespace MathSubtraction
{
    public interface IMathSubtraction<T>
    {
        T Perform(T value1, T value2);
    }
}