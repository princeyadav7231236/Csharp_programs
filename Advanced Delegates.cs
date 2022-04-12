using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Delegates
{
    delegate int SampleDelegate(int a, int b);
    class Program
    {
        public static int sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Assigning a static method to a delegate object :) ");
            SampleDelegate dlgt= sum;
            int total = dlgt(45, 55);
            Console.WriteLine("The sum of 45 and 55 is :--> {0}", total);         // 100
            Console.WriteLine("dlgt.Target = {0}", dlgt.Target);                  // null
            Console.WriteLine("dlgt.Target == null ? {0}", dlgt.Target == null);  // True

            Console.WriteLine("dlgt.Method = {0}", dlgt.Method);                  // Int32 sum(Int32, Int32)
            OutsideProgram op = new OutsideProgram();
            Console.WriteLine("Assigning a Instance method to a delegate object :) ");
            dlgt = op.CalculateSum;
            total = dlgt(10, 20);
            Console.WriteLine("The sum of 45 and 55 is :--> {0}", total);         // 30
            Console.WriteLine("dlgt.Target = {0}", dlgt.Target);                  // Advanced_Delegates.Program+OutsideProgram
            Console.WriteLine("dlgt.Target == null ? {0}", dlgt.Target == null);  // False

            Console.WriteLine("dlgt.Method = {0}", dlgt.Method);                  //  Int32 CalculateSum(Int32, Int32)

            Console.ReadLine();
        }
        class OutsideProgram
        {
            public int CalculateSum(int x, int y)
            {
                return x + y;
            }
        }
    }
}
