using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Structs
    {
        struct Doohickey
        {
            public int Position;
            public bool Exists;
            public double LastValue;
        };
        public Structs()
        {
            Doohickey d;
            d.LastValue = 1;
        }
    }
}
