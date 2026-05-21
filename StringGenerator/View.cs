using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringGenerator
{
    public class View
    {
        public void WriteOutput(string output)
        {
            Console.WriteLine(output);
        }

        public void ErrorMessage()
        {
            Console.WriteLine("Nope");
        }
    }
}