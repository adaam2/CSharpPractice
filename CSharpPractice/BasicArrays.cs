using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class BasicArrays
    {
        public BasicArrays()
        {
            string[] arr1 = { "1", "2", "3" };
            int[] arr2 = { 1, 2, 3 };
            foreach (string s in arr1)
            {
                foreach (int i in arr2)
                {
                    if (Convert.ToInt16(s) == i)
                    {
                        Console.WriteLine("yes matched (obviously)");
                    }
                }
            }
        }
    }
}
