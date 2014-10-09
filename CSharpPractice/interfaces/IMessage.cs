using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.interfaces
{
    public interface IMessage
    {
        void ReceiveMessage(string msg);
    }

    public class BasicMessager : IMessage
    {
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("This is a message from " + this.GetType().Name + ": " + message);
        }
    }

}
