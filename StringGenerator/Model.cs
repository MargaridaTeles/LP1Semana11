using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringGenerator
{
    public class Model
    {
        public string Seed { get; private set; }
        public Model(string seed)
        {
            Seed = seed;
        }
    }
}