using System;

namespace StringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model(int.Parse(args[0]));

            Controller controller = new Controller();

            View view = new View();
            view.WriteOutput(controller.Generate(model));
        }
    }
}