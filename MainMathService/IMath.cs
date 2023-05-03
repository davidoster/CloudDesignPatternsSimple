using MathAddition;
using MathSubtraction;

namespace MainMathService
{
    public interface IMath : IMathAddition<double>, IMathSubtraction<double>
    {
        IMathAddition<double> Addition { get; }
        IMathSubtraction<double> Subtraction { get; }
    }
}