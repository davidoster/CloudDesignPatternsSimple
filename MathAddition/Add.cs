namespace MathAddition
{
    public class Add : IMathAddition<double>
    {
        public double Perform(double value1, double value2)
        {
            return value1 + value2;
        }
    }
}