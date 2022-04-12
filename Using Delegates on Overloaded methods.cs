using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_delegates_on_overloaded_method
{
    public delegate int DelegateWithTwoIntParameters(int a, int b);
    class Program
    {
        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static int sum(int x, int y, int z)
        {
            return x + y + z;
        }

        static void Main(string[] args)
        {
            DelegateWithTwoIntParameters dlgt = sum;
            int SumOfTwoNumbers = dlgt(45, 55);
            Console.WriteLine("The sum of two numbers 45 and 55 is : {0}", SumOfTwoNumbers);

            Console.ReadKey();
        }
    }
}
