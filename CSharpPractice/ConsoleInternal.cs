using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class ConsoleInternal
    {
        public ConsoleInternal()
        {
            Console.Title = "Test title";
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.DarkRed;
        }
    }
}
