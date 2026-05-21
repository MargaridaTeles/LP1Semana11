using System;

namespace StringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model(int.Parse(args[0]));

            string output = Generator.Generate(seed);

            View view = new View();
            view.WriteOutput(output);
        }
    }
}