using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_by_Reference_ref_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x);    // 10
            multiplication(ref x);   // 100
            Console.WriteLine(x);    // 100
            Console.ReadLine();
        }
        public static void multiplication(ref int a)
        {
            a *= a;
            Console.WriteLine(a);
        }
    }
}
