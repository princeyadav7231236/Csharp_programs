using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop in C#
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("i value : {0}", i);
            }
            // for loop with multiple variables
            for (int i = 1, k = 0; i < 4; i++, k++)
            {
                Console.WriteLine("i value : {0}, k value {1}", i, k);
            }
            // for loop with break statement
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                    break;
                Console.WriteLine("i value : {0}", i);
            }
            // for loop without Initialization and Iterators
            int j = 1;
            for (;j < 5; )
            {
                Console.WriteLine("j value : {0}", j);
                j++;
            }
            // infinite for loop

            /*for(; ; )
            {
                Console.WriteLine("Doctor and Shinchan");
            }*/

            // infinite for loop
            /*for (int i = 0; i >-5; i++)
            {
                Console.WriteLine("i value : {0}", i);
            }*/

            // Nested for loop
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine("i value : {0}, k value {1}", i, k);
                }
            }


            Console.ReadLine();
        }
    }
}
