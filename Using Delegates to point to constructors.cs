using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Delegates_to_point_to_Constructors
{
    delegate OutSideProgram ConsGenerator();
    class Program
    {
        static void Main(string[] args)
        {
            ConsGenerator consGenerator = () =>
             {
                 return new OutSideProgram();
             };
            consGenerator();

            Console.ReadLine();
        }
    }
    class OutSideProgram
    {
        public OutSideProgram()
        {
            Console.WriteLine("OutSideProgram class Constructor");
        }
    }
}
