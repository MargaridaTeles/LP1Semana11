using System;

namespace StringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed = int.Parse(args[0]);

            string output = Generator.Generate(seed);

            IView view = new View();
            view.WriteOutput(output);
        }
    }
}