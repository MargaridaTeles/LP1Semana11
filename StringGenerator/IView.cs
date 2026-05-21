using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringGenerator
{
    public interface IView
    {
        void WriteOutput(string output);
    }
}