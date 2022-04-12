using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 20; 
            string result;
            result = (x > y) ? "x is greater then y" : "x is less then y";  // Ternary Operator -->    ?:
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
