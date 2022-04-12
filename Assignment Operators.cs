using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            // Addition Assignment
            x += 10;
            Console.WriteLine(x);  // 30

            // Modulo Assignment
            x %= 7;
            Console.WriteLine(x);  // 2

            // Bitwise AND Assignment
            x &= 10;
            Console.WriteLine(x);
            
            // Bitwise Exclusive OR (XOR) Assignment  
            x ^= 12; 
            Console.WriteLine(x);   // 14

            // Right shift Assignment
            x >>= 3;
            Console.WriteLine(x); // 1

            // Bitwise OR Assignment
            x |= 10;
            Console.WriteLine(x);  // 11

            Console.ReadLine();
        }
    }
}
