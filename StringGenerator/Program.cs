using System;

namespace StringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model(args[0]);

            Controller controller = new Controller();

            View view = new View();
            controller.Run(view, model);
            
        }
    }
}