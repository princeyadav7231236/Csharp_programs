using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_value_type_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x);
            multiplication(x);
            Console.WriteLine(x);
            Console.ReadLine();
        }
        public static void multiplication(int a)
        {
            a *= a;
            Console.WriteLine(a);
        }
    }
}
