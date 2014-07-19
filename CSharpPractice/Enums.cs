using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Enums
    {
        enum Importance : byte
        {
            Low,
            Medium,
            High
        }
        public Enums()
        {
            Importance status = Importance.Low;

            if (status == Importance.Low)
            {
                Console.WriteLine("Status is low");
            }

            StackOfEnums();
        }
        private void StackOfEnums()
        {
            Stack<Importance> stack = new Stack<Importance>();
            stack.Push(Importance.Low);
            stack.Push(Importance.High);
            Importance recentTag = stack.Pop();
            Console.WriteLine(recentTag);
        }
    }
}
