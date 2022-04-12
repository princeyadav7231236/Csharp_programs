using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            byte start = (byte)days.Monday;
            byte end = (byte)days.Sunday;
            Console.WriteLine(start);   // 1
            Console.WriteLine(end);     // 7
                                         
            Console.ReadKey();
        }
        enum days
        {
            Monday = 1, Tuesday, Wednesday, Thrusday, Friday, Saturaday, Sunday  // we are changing the default value of monday from 0 to 1
        }
    }
}
