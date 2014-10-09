using System;
using CSharpPractice.interfaces;
using CSharpPractice.interfaces.testClasses;

namespace CSharpPractice
{
    public class Start
    {
        public static void Main(string[] args)
        {       
            //InterfaceTester t = new InterfaceTester(new BasicMessager());
            //t.SendMessage("Hello this is being sent using an interface");


            //ExceptionTester t2 = new ExceptionTester();

            Tasks t3 = new Tasks();

            Console.WriteLine("--END OF FILE--");

            Console.ReadKey(); // necessary to keep console window open long enough to see output!!
        }
    }
}
