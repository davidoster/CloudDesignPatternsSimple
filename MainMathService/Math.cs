using MathAddition;
using MathSubtraction;

namespace MainMathService
{
    public class Math : IMath
    {
        public IMathAddition<double> Addition { get; set; }

        public IMathSubtraction<double> Subtraction { get; set; }

        public Math(IMathAddition<double> addition)
        {
            Addition = addition;
        }

        public Math(IMathSubtraction<double> subtraction)
        {
            Subtraction = subtraction;
        }

        public double Perform(double value1, double value2)
        {

            if (Addition != null)
            {
                return Addition.Perform(value1, value2);
            }
            else
            {
                return Subtraction.Perform(value1, value2);
            }
        }
    }
}