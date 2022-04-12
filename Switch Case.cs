using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            switch (x)
            {
                case 10:
                    Console.WriteLine("x is 10");
                    switch (y)
                    {
                        case 20:
                            Console.WriteLine("y is 20");
                            break;
                        case 5:
                            Console.WriteLine("y is 5");
                            break;
                    }
                    break;
                case 20:
                    Console.WriteLine("x is 20");
                    break;

                default:
                    Console.WriteLine("Not known");
                    break;
            }
            Console.ReadLine();
        }
    }
}
