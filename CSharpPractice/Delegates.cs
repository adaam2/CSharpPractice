using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CSharpPractice
{
    /// <summary>
    /// This class includes lots of practice with delegates
    /// </summary>
    class Delegates
    {
        public Delegates()
        {
            StringProcessor proc = new StringProcessor(PrintString);
            proc.Invoke("Hey this is invoking the PrintString method using a delegate");
            proc("Also another way of calling the PrintString function");

            Person adam = new Person("Adam Bull");
            StringProcessor adamsVoice = new StringProcessor(adam.Say);
            adamsVoice("Hey i'm a web dev");
        }
        delegate void StringProcessor(string input); // delegate type
        void PrintString(string x)
        {
            debugFunctions.Print(x);
        }
    }
    class Person
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }
        public void Say(string message)
        {
            debugFunctions.Print(name + " says " + message);
        }
        public override string ToString()
        {
            return "This person's name is " + this.name;
        }
    }
}
