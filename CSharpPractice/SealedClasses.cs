using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class SealedTester
    {
        public SealedTester()
        {
            Sealed i = new Sealed();
        }
    }
    sealed class Sealed
    {
        public Sealed()
        {
            // no implementation
        }
    }
    //class Child : Sealed
    //{
    //    // cant inherit from Sealed so commented out otherwise there'll be a build error
    //}
}
