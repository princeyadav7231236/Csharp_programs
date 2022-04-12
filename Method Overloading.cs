using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Calculator
    {
        public void AddNumber(int a, int b)
        {
            Console.WriteLine("The sum of {0} and {1} is = {2}", a, b, a + b);
        }
        public void AddNumber(int a, int b, int c)
        {
            Console.WriteLine("The sum of {0}, {1} and {2} is = {3}", a, b, c, a + b + c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.AddNumber(4, 5);              // The sum of 4 and 5 is = 9
            calc.AddNumber(4, 5, 11);          // The sum of 4, 5 and 11 is = 20

            Console.ReadLine();
        }
    }
}
