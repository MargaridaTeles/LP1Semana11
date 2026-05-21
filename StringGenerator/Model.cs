using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringGenerator
{
    public class Model
    {
        public int Seed { get; private set; }
        public Model(int seed)
        {
            Seed = seed;
        }
    }
}