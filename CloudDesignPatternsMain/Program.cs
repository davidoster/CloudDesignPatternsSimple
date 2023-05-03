using MainMathService;
using MathAddition;

namespace CloudDesignPatternsMain
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            // Sidecar cloud design pattern
            MainMathService.Math math = new MainMathService.Math(new MathAddition.Add());
            Console.WriteLine(math.Perform(1,1));

            math = new MainMathService.Math(new MathSubtraction.Subtract());
            Console.WriteLine(math.Perform(1,1));


        }
    }
}