using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringGenerator
{
    public class View : IView
    {
        public void WriteOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
}