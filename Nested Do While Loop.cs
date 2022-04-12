using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            do
            {
                Console.WriteLine(" x is {0}", x);
                x++;
                int j = 1;
                do
                {
                    Console.WriteLine(" j is {0}", j);
                    j++;
                } while (j < 3);
            } while (x < 4);
            Console.ReadLine();
        }
    }
}
