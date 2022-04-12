using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, result;            
            // Bitwise AND
            result = x & y;           
            Console.WriteLine(result);  // 0

            // Bitwise OR
            result = x | y;
            Console.WriteLine(result);   // 15

            // Bitwise Exclusive OR (XOR)
            result = x ^ y;
            Console.WriteLine(result);    // 15

            // Bitwise Complement
            result = ~x;
            Console.WriteLine(result);     // -6

            // Bitwise Left Shift
            result = y << 2;
            Console.WriteLine(result);     // 20

            // Bitwise Right Shift 
            result = y >> 2;
            Console.WriteLine(result);     // 1

            Console.ReadLine();
        }
    }
}
