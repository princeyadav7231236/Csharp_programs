using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            multiplication(out x);  // 100
            Console.WriteLine(x);   // 100
            Console.ReadLine();
        }
        public static void multiplication(out int a)
        {
            a = 10;
            a *= a;
            Console.WriteLine(a);
        }
    }
}
