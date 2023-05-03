namespace MathSubtraction
{
    public class Subtract : IMathSubtraction<double>
    {
        public double Perform(double value1, double value2)
        {
            return value1 - value2;
        }
    }
}