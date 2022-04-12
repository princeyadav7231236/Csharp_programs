using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Else_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 20;
            if(x > y)
            {
                if (x >= 10)
                    Console.WriteLine("x is greater then 10");
                else
                    Console.WriteLine("x is less then 10");
            }
            else
            {
                if (y <= 20)
                    Console.WriteLine("y is less than or equal to 20");
                else
                    Console.WriteLine("y is greater then 20");
            }
            Console.ReadLine();
        }
    }
}
