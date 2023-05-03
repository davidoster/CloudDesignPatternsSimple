using MainMathService;
using MathAddition;

namespace CloudDesignPatternsMain
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            // Sidecar cloud design pattern
            // MainMathService is the main bike
            // MathAddition (or MathSubtraction) is the sidecar that supports the bike (MainMathService)
            MainMathService.Math math = new MainMathService.Math(new MathAddition.Add());
            math = new MainMathService.Math(new MathSubtraction.Subtract());
            Console.WriteLine(math.Perform(1,1));
            Console.WriteLine(math.Perform(1,1));

            // Ambassador
            // create a new ambassador
            // and give to it its main functionality / ies
            MainMathService.Math ambassador = new MainMathService.Math(new MathAddition.Add(), new MathSubtraction.Subtract());
            var results = ambassador.PerformAll(1,1);
            results.ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}