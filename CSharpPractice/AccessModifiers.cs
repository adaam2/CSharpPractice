using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class AccessModifiers
    {
        public string testString = "";
        public void PublicMethod() {
            // do stuff
        }
        private void PrivateMethod()
        {
            // do stuff
        }
       
        //private static void PrivateStaticMethod {
        //    // This static method can be used by all instances of this class
        //    // i.e. AccessModifiers.PrivateStaticMethod();
        //    // Static methods in non-static context work on the class itself, not the specific instance
            
        //}
    }
}
