using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case_statement_with_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            location loc = location.Hyderabad;
            switch (loc)
            {
                case location.Chennai:
                    Console.WriteLine("Location : Chennai");
                    break;
                case location.Guntur:
                    Console.WriteLine("Location : Guntur");
                    break;
                case location.Hyderabad:
                    Console.WriteLine("Location : Hyderabad");
                    break;
                default:
                    Console.WriteLine("Not Known");
                    break;
            }
            Console.ReadLine();
        }
        public enum location
        {
            Hyderabad,
            Chennai, Guntur
        }
    }
}
