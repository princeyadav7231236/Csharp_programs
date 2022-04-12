using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_in_Csharp
{
    public delegate void SampleDelegate(int a, int b);
    class MathOperation
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation m = new MathOperation();
            SampleDelegate dlgt = m.Add;  // 29
            dlgt += m.Sub;                // 21
            dlgt += m.Mul;                // 100
            dlgt(25, 4);                  
            SampleMethod(m.Div, 30, 6);   // 5
            // Invoking delegate by using its Invoke property.
            dlgt.Invoke(50, 2);           // 52; 48; 100

            Console.ReadLine();
        }
        static void SampleMethod(SampleDelegate dlgt, int a, int b)
        {
            dlgt(a, b);
        }
    }
}
