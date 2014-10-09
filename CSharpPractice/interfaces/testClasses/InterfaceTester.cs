using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.interfaces.testClasses
{
    public class InterfaceTester
    {
        private IMessage _messager;
        public InterfaceTester(IMessage messager)
        {
            this._messager = messager;
            
        }
        public void SendMessage(string s)
        {
            _messager.ReceiveMessage(s);
        }
    }
}
