using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates_in_Csharp
{
    delegate int multiDelegate();
    class Program
    {
        public static int MethodOne()
        {
            Console.WriteLine("Method one");
            return 1;
        }
        public static int MethodTwo()
        {
            Console.WriteLine("Method Two");
            return 2;
        }
        public static int MethodThree()
        {
            Console.WriteLine("Method Three");
            return 3;
        }
        static void Main(string[] args)
        {
            multiDelegate multiDel = MethodOne;
            multiDel += MethodTwo;
            multiDel += MethodThree;
            int finalValue = multiDel();
            Console.WriteLine("The final value is {0}", finalValue);    // The final value is 3

            Console.ReadLine();
        }
    }
}
